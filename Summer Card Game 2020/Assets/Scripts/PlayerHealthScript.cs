using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthScript : MonoBehaviour
{
    public int health = 40;

    public int mana = 10;

    public Text healthText;

    public Text manaText;

    public bool manaUsable = true;

    private void Start()
    {

        healthText.text = "Player Health: " + health;

        manaText.text = "Player Mana: " + mana;

    }
}
