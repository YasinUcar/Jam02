using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_TakeDamage : MonoBehaviour
{
    int enemyHealth = 100;
    int damage = 25;

    public void OnCollisionEnter(Collision _col)
    {
        if (_col.gameObject.tag ==("MyWeapon"))
        {
            enemyHealth -= damage;
            print(enemyHealth);
        }
    }

}
