using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    OrderManager orderManager;
    //da associarli manualmente
    public Button enigma_7;

    void Start()
    {
        orderManager = FindObjectOfType<OrderManager>();
    }

    public void Correct()
    {
        if (orderManager.order == 7)
        {
            //SUCCESSO, CAMBIO SPRITE
            orderManager.Procede();
            enigma_7.interactable = false;
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
