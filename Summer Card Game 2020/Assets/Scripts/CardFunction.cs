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
            enemy.GetComponent<EnemyFunction>().TakeDamage(card.attackVal);
        }

        if(card.protectVal != 0)
        {
            player.GetComponent<PlayerHealthScript>().shield = player.GetComponent<PlayerHealthScript>().shield + card.protectVal;
            player.GetComponent<PlayerHealthScript>().shieldText.text = "Def: " + player.GetComponent<PlayerHealthScript>().shield;
        }

        if(card.debuffVal != 0)
        {
            enemy.GetComponent<EnemyFunction>().debuffVal = enemy.GetComponent<EnemyFunction>().debuffVal + card.debuffVal;
            enemy.GetComponent<EnemyFunction>().enemyDebuff.text = "Debuff: " + enemy.GetComponent<EnemyFunction>().debuffVal;
        }

    }
}
