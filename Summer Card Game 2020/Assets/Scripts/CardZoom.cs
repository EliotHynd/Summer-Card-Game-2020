using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class CardZoom : MonoBehaviour
{
    public GameObject canvas;
    private GameObject zoomCard;
    public GameObject zoomfield;

    public void Awake()
    {
        canvas = GameObject.Find("Main Canvas");
        zoomfield = GameObject.Find("ZoomField");
    }

    public void OnHoverEnter()
    {
        zoomCard = Instantiate(gameObject, new Vector2(zoomfield.transform.position.x, zoomfield.transform.position.y), Quaternion.identity);
        zoomCard.transform.SetParent(canvas.transform, false);
        zoomCard.layer = LayerMask.NameToLayer("Zoom");

        RectTransform rect = zoomCard.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(200, 260);

    }

    public void OnHoverExit()
    {
        Destroy(zoomCard);
    }
}
