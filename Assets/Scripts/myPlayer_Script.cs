using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlayer_Script : MonoBehaviour
{
    public float speed = 1f;
    public int playerHealth=100;
    int damage=10;
    public int selectedWeapon = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        float XDirection = Input.GetAxis("Horizontal");
        float ZDirection = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(XDirection, 0.0f, ZDirection);
        transform.position += moveDirection*speed;
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("enemyWeapon"))
        {
            playerHealth -= damage;
        }
    }
}
