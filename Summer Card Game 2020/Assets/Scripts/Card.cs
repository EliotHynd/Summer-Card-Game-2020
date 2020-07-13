using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    //Card Info
    //Strings
    public string cardName;
    public string description;
    //Sprites
    public Sprite artwork;
    //Ints
    public int manaCost;
    public int attackVal;
    public int protectVal;
    public int debuffVal;
    public int healthVal;

    public void Print ()
    {
        Debug.Log(cardName + ": " + description + " The card costs: " + manaCost);
    }


}
