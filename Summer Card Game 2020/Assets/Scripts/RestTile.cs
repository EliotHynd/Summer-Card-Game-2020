using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestTile : MonoBehaviour
{
    public GameObject playerLocal;
    GameObject player;
    public GameObject previousTile;

    public int heal = 20;

    bool hasHealed = false;

    private void Start()
    {
        player = GameObject.Find("PlayerStats");
    }

    public void PlayerLocal()
    {
        playerLocal.SetActive(true);
        previousTile.SetActive(false);
    }

    public void Heal()
    {

        player.GetComponent<PlayerHealthScript>().Heal(heal);
        gameObject.GetComponent<Button>().enabled = false;

    }


}
