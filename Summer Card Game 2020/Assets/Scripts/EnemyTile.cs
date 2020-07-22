using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTile : MonoBehaviour
{
    public int enemySceneLoad;

    public GameObject playerLocal;

    public void LoadEnemy ()
    {

        enemySceneLoad = Random.Range(1, 4);

        SceneManager.LoadScene(enemySceneLoad, LoadSceneMode.Single);
    }

    public void PlayerLocal()
    {
        playerLocal.SetActive(true);
    }
}
