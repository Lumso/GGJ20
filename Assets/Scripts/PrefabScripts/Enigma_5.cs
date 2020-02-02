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
    public GameObject valveObj;
    public float rotationTime = 1.276f;
    public float rotationSpeed = 2.3451f;
    private bool isRotating = false;
    public AudioSource objectAudio;

    void Start()
    {
        orderManager = FindObjectOfType<OrderManager>();
    }

    private void Update()
    {
        if (isRotating) valveObj.transform.Rotate(0f, 0f, rotationSpeed);
    }


    public void Correct()
    {
        if (orderManager.order == 5)
        {
            objectAudio.Play();
            isRotating = true;
            StartCoroutine(RotationTimeout());

            orderManager.Procede();
            enigma_5.enabled = false;
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

    private IEnumerator RotationTimeout()
    {
        yield return new WaitForSeconds(rotationTime);
        isRotating = false;
    }
}
