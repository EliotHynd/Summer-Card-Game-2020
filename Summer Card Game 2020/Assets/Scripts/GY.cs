using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GY : MonoBehaviour
{
    public GameObject hand;
    public GameObject deck;

    public List<GameObject> gycards = new List<GameObject>();

    public int gyamount;
    public int deckamount;

    public Text gyText;

    private void Start()
    {
        deckamount = deck.GetComponent<Deck>().decknum;
    }
    void Update()
    {
        gyamount = gycards.Count;
        gyText.text = gyamount.ToString();

    }

    public void GYToDeck()
    {
        int temp = gycards.Count;
        for (var i = 0; i < temp; i++)
        {
            deck.GetComponent<Deck>().cards.Add(gycards.Last<GameObject>());

            gycards.RemoveAt(gycards.Count - 1);
        }
        gycards.Clear();
        deck.GetComponent<Deck>().Shuffle(deck.GetComponent<Deck>().cards);
    }
}
