using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyFunction : MonoBehaviour
{
    public Enemy enemy;

    public Text enemyName;
    public Text enemyHealth;

    public int currentHealth; 

    GameObject player;
    public GameObject sceneManager;

    private void Start()
    {
        enemyName.text = enemy.enemyName;
        enemyHealth.text = "Enemy Health: " + enemy.enemyHealth;
        currentHealth = enemy.enemyHealth;

        player = GameObject.Find("PlayerStats");

        sceneManager = GameObject.Find("LevelManager");
    }

    private void Update()
    {
        EnemyDeath();
    }

    public void EnemyTurn()
    {
        int attack = Random.Range(enemy.enemyMinDamage, enemy.enemyMaxDamage);

        player.GetComponent<PlayerHealthScript>().currentHealth = player.GetComponent<PlayerHealthScript>().currentHealth - attack;
        player.GetComponent<PlayerHealthScript>().healthText.text = "Player Health: " + player.GetComponent<PlayerHealthScript>().currentHealth;
    }

    public void EnemyDeath()
    {
        if (currentHealth <= 0)
        {
            sceneManager.GetComponent<LevelManager>().LoadWin();
        }
    }
}
