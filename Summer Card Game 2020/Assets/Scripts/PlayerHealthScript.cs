using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthScript : MonoBehaviour
{
    public int health = 40;
    public int currentHealth;
    public int mana = 10;
    public int currentMana;
    public int shield = 0;
    public int debuffVal;

    public Text healthText;
    public Text manaText;
    public Text shieldText;

    public GameObject sceneManager;

    private void Start()
    {
        currentHealth = health;
        currentMana = mana;

        healthText.text = "Player Health: " + currentHealth;
        manaText.text = "Player Mana: " + currentMana;
        shieldText.text = "Def: " + shield;

        sceneManager = GameObject.Find("LevelManager");

    }

    public void TakeDamage(int damage)
    {
        if (debuffVal != 0)
        {
            Debug.Log("Damage before: " + damage);
            damage += debuffVal;
            Debug.Log("Damage after: " + damage);
        }
        int shieldtake = damage;
        damage -= shield;
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        shield -= shieldtake;
        shield = Mathf.Clamp(shield, 0, int.MaxValue);
        shieldText.text = "Def: " + shield;
        currentHealth -= damage;
        healthText.text = "Player Health: " + currentHealth;

        if (currentHealth <= 0)
        {
            PlayerDeath();
        }
    }

    void PlayerDeath()
    {

        sceneManager.GetComponent<LevelManager>().LoadSpecificLevel();

    }
}
