using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyFunction : MonoBehaviour
{
    public Enemy enemy;

    public Text enemyName;
    public Text enemyHealth;
    public Text enemyDebuff;
    public Text enemyShield;

    public int currentHealth;
    public int debuffVal;
    public int shield = 0;
    int attackChoice;

    GameObject player;
    public GameObject sceneManager;

    bool hasDebuffed = false;
    bool isAttack2 = false;
    bool isAttack3 = false;
    bool hasAttacked = false;

    private void Start()
    {
        enemyName.text = enemy.enemyName;
        enemyHealth.text = "Enemy Health: " + enemy.enemyHealth;
        currentHealth = enemy.enemyHealth;
        enemyShield.text = "Def: " + shield;

        player = GameObject.Find("PlayerStats");

        sceneManager = GameObject.Find("LevelManager");
    }

    private void Update()
    {
        EnemyDeath();
    }

    public void EnemyTurn()
    {
        EnemyAttack();
        if (enemy.attack2)
        {
            isAttack2 = true;
            EnemyAttack();
        }
        if (enemy.attack3)
        {
            isAttack3 = true;
            EnemyAttack();
        }

        hasDebuffed = false;
        hasAttacked = false;
        isAttack2 = false;
        isAttack3 = false;
    }

    public void TakeDamage (int damage)
    {
        if (debuffVal != 0)
        {
            damage += debuffVal;
        }
        int shieldtake = damage;
        damage -= shield;
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        shield -= shieldtake;
        shield = Mathf.Clamp(shield, 0, int.MaxValue);
        enemyShield.text = "Def: " + shield;
        currentHealth -= damage;
        enemyHealth.text = "Enemy Health: " + currentHealth;

        if (currentHealth <= 0)
        {
            EnemyDeath();
        }
    }

    public void EnemyDeath()
    {
        if (currentHealth <= 0)
        {
            sceneManager.GetComponent<LevelManager>().LoadWin();
        }
    }

    void EnemyAttack()
    {
        if(!enemy.attack2)
        {
            attackChoice = Random.Range(0, 2);
        } else 
        {
            attackChoice = Random.Range(0, 3);
        }

        if (isAttack2 && hasDebuffed && !enemy.attack3)
        {
            attackChoice = 0;
        } else if (isAttack2 && !hasDebuffed && !enemy.attack3)
        {
            attackChoice = Random.Range(0, 2);
        } else if (isAttack2 && enemy.attack3)
        {
            attackChoice = Random.Range(0, 3);
        }

        if (isAttack3 && hasDebuffed && !hasAttacked)
        {
            attackChoice = 0;
        } else if (isAttack3 && !hasDebuffed)
        {
            attackChoice = Random.Range(0, 2);
        } else if (isAttack3 && hasDebuffed && hasAttacked)
        {
            attackChoice = Random.Range(0, 2);
        }

        if (attackChoice == 0)
        {
            int attack = Random.Range(enemy.enemyMinDamage, enemy.enemyMaxDamage +1);

            Debug.Log("Attack Damage: " + attack);

            player.GetComponent<PlayerHealthScript>().TakeDamage(attack);

            if (isAttack2 && hasDebuffed)
            {
                hasAttacked = true;
            }

        }
        else if (attackChoice == 1)
        {
            shield += enemy.enemyShield;
            enemyShield.text = "Def: " + shield;

            Debug.Log("Shield: +" + shield);
        }
        else if (attackChoice == 2)
        {
            player.GetComponent<PlayerHealthScript>().debuffVal = player.GetComponent<PlayerHealthScript>().debuffVal += enemy.enemyDebuff;

            Debug.Log("Debuffed: " + debuffVal);

            hasDebuffed = true;

        }

    }
}
