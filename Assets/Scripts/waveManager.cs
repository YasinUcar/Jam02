using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class waveManager : MonoBehaviour
{
    // Start is called before the first frame update

    float timeLeft = 0;
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

            timeLeft += Time.deltaTime;
            if (timeLeft >= 0)
            {
                time.text = "Wave 1/5 " + timeLeft.ToString();
            }
            else if (timeLeft >= 30)
            {
                time.text = "Wave 2/5 " + timeLeft.ToString();
            }
            else if (timeLeft >= 60)
            {
                time.text = "Wave 3/5 " + timeLeft.ToString();
            }
            else if (timeLeft >= 90)
            {
                time.text = "Wave 4/5 " + timeLeft.ToString();
            }
            else if (timeLeft >= 120)
            {
                time.text = "Wave 5/5 " + timeLeft.ToString();
            }
        }

    }
}


