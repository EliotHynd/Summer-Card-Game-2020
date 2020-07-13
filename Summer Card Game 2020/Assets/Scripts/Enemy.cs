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
}
