using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigma_1 : MonoBehaviour
{
    OrderManager orderManager;
    public Button enigma1;
    public GameObject tube_off;
    public GameObject tube_on;


    void Start()
    {
        orderManager = FindObjectOfType<OrderManager>();

        tube_off.SetActive(true);
        tube_on.SetActive(false);
    }

    public void buttonRightPressed()
    {
        tube_off.SetActive(false);
        tube_on.SetActive(true);

        orderManager.Procede();
        enigma1.gameObject.GetComponent<Button>().enabled = false;
    }
}