using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFunction : MonoBehaviour
{
    public Card card;

    public GameObject enemy;
    public GameObject player;

    private void Start()
    {
        card = gameObject.GetComponent<CardDisplay>().card;

        player = GameObject.Find("PlayerStats");
        enemy = GameObject.Find("EnemyStats");
    }

    public void CardFunctionality()
    {
        if (card.healthVal != 0)
        {
            player.GetComponent<PlayerHealthScript>().currentHealth = player.GetComponent<PlayerHealthScript>().currentHealth + card.healthVal;
            player.GetComponent<PlayerHealthScript>().healthText.text = "Player Health: " + player.GetComponent<PlayerHealthScript>().currentHealth;
        }

        if (card.attackVal != 0)
        {
            enemy.GetComponent<EnemyFunction>().currentHealth = enemy.GetComponent<EnemyFunction>().currentHealth - card.attackVal;
            enemy.GetComponent<EnemyFunction>().enemyHealth.text = "Enemy Health: " + enemy.GetComponent<EnemyFunction>().currentHealth;
        }

    }
}
