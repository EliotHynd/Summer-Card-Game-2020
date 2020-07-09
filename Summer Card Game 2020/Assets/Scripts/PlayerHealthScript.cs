﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthScript : MonoBehaviour
{
    public int health = 40;
    public int currentHealth;
    public int mana = 10;
    public int currentMana;

    public Text healthText;
    public Text manaText;

    private void Start()
    {
        currentHealth = health;
        currentMana = mana;

        healthText.text = "Player Health: " + currentHealth;
        manaText.text = "Player Mana: " + currentMana;

    }
}
