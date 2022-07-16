using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlayer_Script : MonoBehaviour
{
    public float speed = 1f;
    public int playerHealth=100;
    int damage=10;
    zarScript Zar;
    public GameObject Weapon;
    public GameObject Weapon1;
    public GameObject Weapon2;
    public int sayi;
    void Awake()
    {
        Zar = GetComponent<zarScript>();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        float XDirection = Input.GetAxis("Horizontal");
        float ZDirection = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(XDirection, 0.0f, ZDirection);
        transform.position += moveDirection*speed;
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
        switch (sayi)
        {
            case (1):  // +-
                Weapon2.SetActive(true);
                print("Silah Kuþanýldý");
                break;
            case (2):  // -+
                Weapon2.SetActive(true);
                print("Eline Kuþanýldý");
                break;
            case (3):  // ++
                Weapon.SetActive(true);
                print("Eline Sila ");
                break;
            case (4):  // --
                Weapon1.SetActive(true);
                print("Eline");
                break;
        }
    }

}