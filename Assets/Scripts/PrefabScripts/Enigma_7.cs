using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigma_7 : MonoBehaviour
{
    // Start is called before the first frame update
    OrderManager orderManager;
    //da associarli manualmente
    public Button enigma_7;
    private bool isRotating = false;
    public GameObject valvePivot;
    public AudioSource objectAudio;

    void Start()
    {
        orderManager = FindObjectOfType<OrderManager>();
    }

    private void Update()
    {
        if (isRotating) valvePivot.transform.Rotate(0f, 0f, -1f);
        if (valvePivot.transform.rotation.z <= 0f) isRotating = false;
    }


    public void Correct()
    {
        if (orderManager.order == 7)
        {
            objectAudio.Play();
            isRotating = true;
            orderManager.Procede();
            enigma_7.enabled = false;
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
