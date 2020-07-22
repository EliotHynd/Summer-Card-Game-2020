using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public GameObject enemyTile;
    public GameObject miniBossTile;
    public GameObject bossTile;
    public GameObject restTile;
    public GameObject chanceTile;
    public GameObject startTile;

    public int tileChoice;

    private void Update()
    {
        TileDisplay();
    }

    public void TileDisplay()
    {
        if (tileChoice == 0)
        {
            StartTile();
        }
        else if (tileChoice == 1)
        {
            EnemyTile();
        }
        else if (tileChoice == 2)
        {
            MiniBossTile();
        }
        else if (tileChoice == 3)
        {
            BossTile();
        }
        else if (tileChoice == 4)
        {
            RestTile();
        }
        else if (tileChoice == 5)
        {
            ChanceTile();
        }
    }

    void EnemyTile()
    {
        enemyTile.SetActive(true);
        miniBossTile.SetActive(false);
        bossTile.SetActive(false);
        restTile.SetActive(false);
        chanceTile.SetActive(false);
        startTile.SetActive(false);

        /*
        gameObject.GetComponent<Button>().onClick.AddListener(enemyTile.GetComponent<EnemyTile>().LoadEnemy);
        */
    }

    void MiniBossTile()
    {        
        miniBossTile.SetActive(true);
        enemyTile.SetActive(false);
        bossTile.SetActive(false);
        restTile.SetActive(false);
        chanceTile.SetActive(false);
        startTile.SetActive(false);
    }

    void BossTile()
    {
        bossTile.SetActive(true);
        enemyTile.SetActive(false);
        miniBossTile.SetActive(false);
        restTile.SetActive(false);
        chanceTile.SetActive(false);
        startTile.SetActive(false);
    }

    void RestTile()
    {
        restTile.SetActive(true);
        enemyTile.SetActive(false);
        miniBossTile.SetActive(false);
        bossTile.SetActive(false);
        chanceTile.SetActive(false);
        startTile.SetActive(false);
    }

    void ChanceTile()
    {
        chanceTile.SetActive(true);
        enemyTile.SetActive(false);
        miniBossTile.SetActive(false);
        bossTile.SetActive(false);
        restTile.SetActive(false);
        startTile.SetActive(false);
    }

    void StartTile()
    {
        startTile.SetActive(true);
        enemyTile.SetActive(false);
        miniBossTile.SetActive(false);
        bossTile.SetActive(false);
        restTile.SetActive(false);
        chanceTile.SetActive(false);
    }


}
