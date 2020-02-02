using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigma_5 : MonoBehaviour
{
    // Start is called before the first frame update
    OrderManager orderManager;
    //da associarli manualmente
    public Button enigma_5;

    void Start()
    {
        orderManager = FindObjectOfType<OrderManager>();
    }

    public void Correct()
    {
        if (orderManager.order == 5)
        {
            //SUCCESSO, CAMBIO SPRITE
            orderManager.Procede();
            enigma_5.interactable = false;
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
