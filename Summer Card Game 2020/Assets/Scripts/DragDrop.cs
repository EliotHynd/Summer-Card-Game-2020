using System.Collections;
using System.Collections.Generic;
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

    private Vector2 startPosition;

    private void Awake()
    {
        canvas = GameObject.Find("Main Canvas");
        player = GameObject.Find("HMStats");

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
        isDragging = false;
        if (isOverDropZone && player.GetComponent<PlayerHealthScript>().manaUsable == true)
        {
            transform.SetParent(dropZone.transform, false);
        } else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }
    }
}
