using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class EndTurn : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject gy;
    public GameObject drawCards;

    private void Start()
    {
        player = GameObject.Find("PlayerStats");
        enemy = GameObject.Find("EnemyStats");
        gy = GameObject.Find("GY");
        drawCards = GameObject.Find("Deal");

    }
    public void EndingTurn()
    {
        enemy.GetComponent<EnemyFunction>().shield = 0;
        enemy.GetComponent<EnemyFunction>().enemyShield.text = "Def: " + enemy.GetComponent<EnemyFunction>().shield;

        enemy.GetComponent<EnemyFunction>().EnemyTurn();

        player.GetComponent<PlayerHealthScript>().currentMana = player.GetComponent<PlayerHealthScript>().mana;
        player.GetComponent<PlayerHealthScript>().manaText.text = "Player Mana: " + player.GetComponent<PlayerHealthScript>().currentMana;

        gy.GetComponent<GY>().GYToDeck();

        drawCards.GetComponent<DrawCards>().Draw();

        enemy.GetComponent<EnemyFunction>().debuffVal = 0;
        enemy.GetComponent<EnemyFunction>().enemyDebuff.text = "";

        player.GetComponent<PlayerHealthScript>().debuffVal = 0;
    }
}
