using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigma_2 : MonoBehaviour
{
    OrderManager orderManager;
    //da associarli manualmente
    public Button enigma2_Right;
    public Button enigma2_Wrong;
    public AudioSource objectAudio;

    public Image button_right;
    public Image button_wrong;

    public Sprite sprite_on;
    public Sprite sprite_off;


    void Start()
    {
        orderManager = FindObjectOfType<OrderManager>();
    }

    public void Correct()
    {
        if(orderManager.order == 2)
        {
            objectAudio.Play();

            button_right.sprite = sprite_on;
            button_wrong.sprite = sprite_on;

            button_right.sprite = sprite_off;

            enigma2_Right.enabled = false;
            enigma2_Wrong.enabled = false;

            orderManager.Procede();
            enigma2_Right.interactable = false;
            enigma2_Wrong.interactable = false;
        }
        else
        {
            Wrong();
        }
    }

    public void Wrong()
    {
        if (OrderManager._ORDER_MANAGER.order == 2) button_wrong.sprite = sprite_off;
        orderManager.Error();
    }
}
