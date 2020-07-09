using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndTurn : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("PlayerStats");
    }
    public void EndingTurn()
    {
        player.GetComponent<PlayerHealthScript>().currentMana = player.GetComponent<PlayerHealthScript>().mana;
        player.GetComponent<PlayerHealthScript>().manaText.text = "Player Mana: " + player.GetComponent<PlayerHealthScript>().currentMana;
    }
}
