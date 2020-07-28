using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Deck : MonoBehaviour
{
    public GameObject card1, card2, card3, card4, card5, card6, card7, card8;

    public Text cardcount;

    public int decknum;


    public List<GameObject> cards = new List<GameObject>();

    void Start()
    {
        cards.Add(card1);
        cards.Add(card2);
        cards.Add(card3);
        cards.Add(card4);
        cards.Add(card5);
        cards.Add(card6);
        cards.Add(card7);
        cards.Add(card8);

        decknum = cards.Count;

        Shuffle(cards);

    }

    private void Update()
    {
        int num = cards.Count;

        decknum = num;

        cardcount.text = num.ToString();
    }

    public void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }



}
