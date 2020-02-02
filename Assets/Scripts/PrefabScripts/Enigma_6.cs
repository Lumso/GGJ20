using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigma_6 : MonoBehaviour
{
    // Start is called before the first frame update
    OrderManager orderManager;
    //da associarli manualmente
    private bool isRotating = false;

    public Button enigma_6;
    public GameObject valvePivot;
    public AudioSource objectAudio;

    void Start()
    {
        orderManager = FindObjectOfType<OrderManager>();
    }

    private void Update()
    {
        if(isRotating) valvePivot.transform.Rotate(0f, 0f, -1f);
        if (valvePivot.transform.rotation.z <= 0f) isRotating = false;
    }

    public void Correct()
    {
        if (orderManager.order == 6)
        {
            objectAudio.Play();
            isRotating = true;
            orderManager.Procede();
            enigma_6.enabled = false;
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
