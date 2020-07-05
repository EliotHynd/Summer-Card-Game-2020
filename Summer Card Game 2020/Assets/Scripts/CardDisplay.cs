using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text nameText;
    public Text descripText;

    public Image artworkImage;

    void Start()
    {
        nameText.text = card.cardName;
        descripText.text = card.description;
        artworkImage.sprite = card.artwork;
    }

}
