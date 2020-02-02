using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OrderManager : MonoBehaviour
{
    #region ATTEMPT_AT_SINGLETON
    public static OrderManager _ORDER_MANAGER;
    #endregion
    //variabile che tiene traccia del numero della mossa da compiere
    public int order = 1;
    public int lifes = 4;

    public float fadeDuration = 0.5f;

    public GameObject life4Obj;
    public GameObject life3Obj;
    public GameObject life2Obj;
    public GameObject life1Obj;

    public AudioSource sndLife1;
    public AudioSource sndLife2;
    public AudioSource sndLife3;
    public AudioSource sndLife4;

    public AudioSource sndCorrect;
    public AudioSource sndError;

    public Animator EndScreen;
    public TextMeshProUGUI EndText;
    public Image EndImage;

    public Sprite victoryImage;
    public Sprite defeatImage;


    private void Awake()
    {
        _ORDER_MANAGER = this;

        life4Obj.SetActive(true);
        life3Obj.SetActive(false);
        life2Obj.SetActive(false);
        life1Obj.SetActive(false);
    }

    private void Start()
    {
        StartCoroutine(FadeIn(sndLife1, fadeDuration));
    }

    //script chiamata dopo ogni mossa corretta
    public void Procede()
    {
        order++;
        sndCorrect.Play();

        switch (order)
        {
            case 3:
                StartCoroutine(FadeIn(sndLife2, fadeDuration));
                break;

            case 5:
                StartCoroutine(FadeIn(sndLife3, fadeDuration));
                break;

            case 6:
                StartCoroutine(FadeIn(sndLife4, fadeDuration));
                break;
        }

        if(order == 9)
        {
            EndText.text = "PLAY AGAIN";
            EndImage.sprite = victoryImage;
            EndScreen.Play("endscreen_pop");
        }


    }

    public void Error()
    {
        lifes--;

        sndError.Play();
        //update sprite
        switch (lifes)
        {
            case 4:
                life4Obj.SetActive(true);
                life3Obj.SetActive(false);
                life2Obj.SetActive(false);
                life1Obj.SetActive(false);
                break;

            case 3:
                life4Obj.SetActive(false);
                life3Obj.SetActive(true);
                life2Obj.SetActive(false);
                life1Obj.SetActive(false);
                break;

            case 2:
                life4Obj.SetActive(false);
                life3Obj.SetActive(false);
                life2Obj.SetActive(true);
                life1Obj.SetActive(false);
                break;

            case 1:
                life4Obj.SetActive(false);
                life3Obj.SetActive(false);
                life2Obj.SetActive(false);
                life1Obj.SetActive(true);
                break;

            case 0:
                EndText.text = "RETRAY";
                EndImage.sprite = defeatImage;
                EndScreen.Play("endscreen_pop");
                break;
        }
    }

    
    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }

    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
    {
        float startVolume = 0.2f;

        audioSource.volume = 0;
        audioSource.Play();

        while (audioSource.volume < 1.0f)
        {
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.volume = 1f;
    }
}
