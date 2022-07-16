using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlayer_Script : MonoBehaviour
{
    public float speed = 1f;
    public int playerHealth = 100;
    int damage = 10;

    public GameObject Weapon;
    public GameObject Weapon1;
    public GameObject Weapon2;

    public int sayi;


    void Start()
    {


    }


    void Update()
    {
        float XDirection = Input.GetAxis("Horizontal");
        float ZDirection = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(XDirection, 0.0f, ZDirection);
        transform.position += moveDirection * speed;
        WeaponSystem();
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("enemyWeapon"))
        {
            playerHealth -= damage;
        }
    }

    void WeaponSystem()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject theZar = GameObject.Find("zarManager");

            zarScript zar = theZar.GetComponent<zarScript>();
            int sayi = zar.zarNumber1;
            int sayi2 = zar.zarNumber2;



            switch (sayi, sayi2)
            {
                case (0, 0):  // +-
                    Weapon2.SetActive(true);
                    print("1. Silah Kuşanıldı");
                    break;
                case (1, 1):  // -+
                    Weapon2.SetActive(true);
                    print("2.Silah Kuşanıldı");
                    break;
                case (0, 1):  // ++
                    Weapon.SetActive(true);
                    print("3.Silah Kuşanıldı ");
                    break;
                case (1, 0):  // --
                    Weapon1.SetActive(true);
                    print("4.Silah Kuşanıldı");
                    break;
            }
        }
    }

}