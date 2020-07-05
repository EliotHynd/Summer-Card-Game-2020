using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GY : MonoBehaviour
{
    public GameObject hand;
    public GameObject deck;

    public List<GameObject> gycards = new List<GameObject>();

    int gyamount = 0;
    int deckamount;

    private void Start()
    {
        deckamount = deck.GetComponent<Deck>().decknum;
    }
    void Update()
    {
        if (gyamount >= deckamount)
        {

        }
    }
}
