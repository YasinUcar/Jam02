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

    Animator m_Animator;


    void Start()
    {
        m_Animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            sayiOlustur();
            
            switch (zarNumber1, zarNumber2)
            {
                case (0, 0): //- -
                             // spriteRenderer.sprite = eksiSprite;
                             //spriteRenderer2.sprite = eksiSprite;
                    eksiZar.SetActive(true);
                    eksiZar2.SetActive(true);

                    break;
                case (1, 1): //+ +
                    //spriteRenderer.sprite = artiSprite;
                    //spriteRenderer2.sprite = artiSprite;
                    artiZar.SetActive(true);
                    artiZar2.SetActive(true);
                    break;
                case (0, 1): //+ - 
                    //spriteRenderer.sprite = artiSprite;
                    //spriteRenderer2.sprite = eksiSprite;
                    eksiZar.SetActive(true);
                    artiZar2.SetActive(true);
                    break;
                case (1, 0): //- + 
                    //spriteRenderer.sprite = eksiSprite;
                    //spriteRenderer2.sprite = artiSprite;
                    artiZar2.SetActive(true);
                    eksiZar.SetActive(true);
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
