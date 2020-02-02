using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigma_6 : MonoBehaviour
{
    // Start is called before the first frame update
    OrderManager orderManager;
    //da associarli manualmente
    public Button enigma_6;

    void Start()
    {
        orderManager = FindObjectOfType<OrderManager>();
    }

    public void Correct()
    {
        if (orderManager.order == 6)
        {
            //SUCCESSO, CAMBIO SPRITE
            orderManager.Procede();
            enigma_6.interactable = false;
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
