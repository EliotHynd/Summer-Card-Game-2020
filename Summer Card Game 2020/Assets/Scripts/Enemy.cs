using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class Enemy : ScriptableObject
{
    public string enemyName;

    public int enemyHealth;
    public int enemyMinDamage;
    public int enemyMaxDamage;
    public int enemyDebuff;
    public int enemyShield;

    public bool attack2;
    public bool attack3;
}
