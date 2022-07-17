using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zarScript : MonoBehaviour
{
    public int zarNumber1;
    public int zarNumber2;
    public SpriteRenderer spriteRenderer, spriteRenderer2; //zar 1,zar2
    public Sprite artiSprite, eksiSprite; //zar1,zar2
    public GameObject zar1, zar2, artiZar, eksiZar, eksiZar2, artiZar2;
    public GameObject[] silahlar; //(dagger, katana, hancer,  axe);
    public GameObject panelDia;
    Animator m_Animator;
    dialogueScript dia;
    public float zaman = 0;
    public bool bastiMi;
    bool ilkSahneMi = true;
    public GameObject zarCanvas;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
        bastiMi = false;
        ilkSahneMi = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (panelDia.active = true)
        {
            dia = GameObject.Find("DialoguePanel").GetComponent<dialogueScript>();
            dia.Kapat();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            bastiMi = true;
            sayiOlustur();

            switch (zarNumber1, zarNumber2)
            {
                case (0, 0): //- - katana
                             // spriteRenderer.sprite = eksiSprite;
                             //spriteRenderer2.sprite = eksiSprite;
                    eksiZar.SetActive(true);
                    eksiZar2.SetActive(true);
                    silahlar[1].SetActive(true);

                    silahlar[0].SetActive(false);
                    silahlar[2].SetActive(false);
                    silahlar[3].SetActive(false);

                    break;
                case (1, 1): //+ + //dagger
                    //spriteRenderer.sprite = artiSprite;
                    //spriteRenderer2.sprite = artiSprite;
                    artiZar.SetActive(true);
                    artiZar2.SetActive(true);
                    silahlar[1].SetActive(true);

                    silahlar[2].SetActive(false);
                    silahlar[0].SetActive(false);
                    silahlar[3].SetActive(false);

                    break;
                case (0, 1): //+ - 
                    //spriteRenderer.sprite = artiSprite;
                    //spriteRenderer2.sprite = eksiSprite;
                    eksiZar.SetActive(true);
                    artiZar2.SetActive(true);
                    silahlar[3].SetActive(true);

                    silahlar[1].SetActive(false);
                    silahlar[2].SetActive(false);
                    silahlar[0].SetActive(false);

                    break;
                case (1, 0): //- + 
                    //spriteRenderer.sprite = eksiSprite;
                    //spriteRenderer2.sprite = artiSprite;
                    artiZar2.SetActive(true);
                    eksiZar.SetActive(true);
                    silahlar[2].SetActive(true);

                    silahlar[1].SetActive(false);
                    silahlar[0].SetActive(false);
                    silahlar[3].SetActive(false);

                    break;

            }
        }

    }
    public void sayiOlustur()
    {
       
      
            zarNumber1 = Random.Range(0, 2);
            zarNumber2 = Random.Range(0, 2);
       
        zar1.SetActive(false);
        zar2.SetActive(false);


    }

}
