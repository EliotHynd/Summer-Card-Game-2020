using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class DrawCards : MonoBehaviour
{
    public GameObject playerZone;
    public GameObject deck;
    public GameObject hand;

    int cardhand;
    
    GridLayoutGroup pzgroup;




    void Start()
    {
        StartCoroutine(LateStart(1));

    }

    private void Update()
    {
        if (cardhand > 5)
        {
            pzgroup = playerZone.GetComponent<GridLayoutGroup>();

            pzgroup.spacing = new Vector2(-10, 0);
        }
    }


    public void Draw()
    {
        int drawamount = 5 - hand.GetComponent<Hand>().handcards.Count;
        Debug.Log("Cards Can Draw: " + drawamount);
        for (var i = 0; i < drawamount; i++)
        {

            GameObject playercard = Instantiate(deck.GetComponent<Deck>().cards.Last<GameObject>(), new Vector3(0, 0, 0), Quaternion.identity);
            playercard.name = deck.GetComponent<Deck>().cards.Last<GameObject>().name;
            playercard.transform.SetParent(playerZone.transform, false);
            hand.GetComponent<Hand>().handcards.Add(deck.GetComponent<Deck>().cards.Last<GameObject>());

            deck.GetComponent<Deck>().cards.RemoveAt(deck.GetComponent<Deck>().cards.Count - 1);

            cardhand = i+1;



        } 


    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Draw();
    }

}
