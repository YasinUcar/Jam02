using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class waveManager : MonoBehaviour
{
    // Start is called before the first frame update

    float timeLeft = 30;
    public TextMeshProUGUI time;
    zarScript zar;


    void Start()
    {

    }
    void Update()
    {
        zar = GameObject.Find("zarManager").GetComponent<zarScript>();
        bool basladiMi = zar.bastiMi;
        if (basladiMi != false)
        {

            timeLeft -= Time.deltaTime;
            time.text = "Wave 1/5 "+ timeLeft.ToString();
            if (timeLeft >= 20)
            {

            }
        }

    }
}


