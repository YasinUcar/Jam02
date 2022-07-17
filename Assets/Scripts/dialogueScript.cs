using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class dialogueScript : MonoBehaviour
{
    public float delay = 0.1f;
    public float speed = 0.1f;
    public string fullText;
    private string currentText = "";
    public float zaman = 0;
    public TextMeshProUGUI targetText;
    public bool zamanbittiMi;
    public int date = 0;
    public GameObject dialogCanvas;
    public GameObject zarCanvas;
    public AudioSource diaSound;
    public AudioClip diaClip;
    void Start()
    {
        StartCoroutine(ShowText());
    }
    void Update()
    {
        date++;
        if (diaSound.isPlaying != true)
        {
            diaSound.PlayOneShot(diaClip);
        }
        zaman += Time.deltaTime;

    }
    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            targetText.text = currentText;
            yield return new WaitForSeconds(delay);

        }
    }
    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Kapat()
    {
        if (zaman >= 20)
        {
            zamanbittiMi = true;
            dialogCanvas.SetActive(false);
            zarCanvas.SetActive(true);
        }
    }
}
