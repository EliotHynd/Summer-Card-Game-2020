using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyTile : MonoBehaviour
{
    public int enemySceneLoad;

    public GameObject playerLocal;
    public GameObject previousTile;

    public void LoadEnemy ()
    {
        gameObject.GetComponent<Button>().enabled = false;

        enemySceneLoad = Random.Range(1, 4);

        SceneManager.LoadScene(enemySceneLoad, LoadSceneMode.Single);
    }

    public void PlayerLocal()
    {
        playerLocal.SetActive(true);
        previousTile.SetActive(false);
    }
}
