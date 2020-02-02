using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Enigma_8 : MonoBehaviour
{
    OrderManager orderManager;
    public Button enigma8;
    public GameObject tube_off;
    public GameObject tube_on;
    public AudioSource objectAudio;


    void Start()
    {
        orderManager = FindObjectOfType<OrderManager>();

        tube_off.SetActive(true);
        tube_on.SetActive(false);
    }

    public void Correct()
    {
        if (orderManager.order == 8)
        {
            objectAudio.Play();
            tube_off.SetActive(false);
            tube_on.SetActive(true);

            orderManager.Procede();
            enigma8.gameObject.GetComponent<Button>().enabled = false;
        }
        else
        {
            Wrong();
        }
    }


    public void Wrong()
    {
        orderManager.Error();
    }
}
