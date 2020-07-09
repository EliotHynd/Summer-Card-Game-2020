using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;
    private bool isOverDropZone = false;
    private bool manaUsable;


    private GameObject dropZone;
    private GameObject canvas;
    private GameObject startParent;
    public GameObject player;
    public GameObject deck;
    public GameObject hand;
    public GameObject gy;

    private Vector2 startPosition;

    private void Awake()
    {
        canvas = GameObject.Find("Main Canvas");
        player = GameObject.Find("PlayerStats");
        deck = GameObject.Find("Deck");
        hand = GameObject.Find("Hand");
        gy = GameObject.Find("GY");
    }

    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(canvas.transform, true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        dropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }

    public void StartDrag()
    {
        startParent = transform.parent.gameObject;
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        if (gameObject.GetComponent<CardDisplay>().card.manaCost <= player.GetComponent<PlayerHealthScript>().currentMana)
        {
            manaUsable = true;
            player.GetComponent<PlayerHealthScript>().currentMana = player.GetComponent<PlayerHealthScript>().currentMana - gameObject.GetComponent<CardDisplay>().card.manaCost;
            player.GetComponent<PlayerHealthScript>().manaText.text = "Player Mana: " + player.GetComponent<PlayerHealthScript>().currentMana;
        }else
        {
            manaUsable = false;
        }
        isDragging = false;
        if (isOverDropZone && manaUsable == true)
        {
            transform.SetParent(dropZone.transform, false);
            gy.GetComponent<GY>().gycards.Add(hand.GetComponent<Hand>().handcards.Where(obj => obj.name == gameObject.name).SingleOrDefault());
            hand.GetComponent<Hand>().handcards.Remove(hand.GetComponent<Hand>().handcards.Where(obj => obj.name == gameObject.name).SingleOrDefault());

            Destroy(gameObject);
        } else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }
    }
}
