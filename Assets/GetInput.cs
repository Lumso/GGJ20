using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInput : MonoBehaviour
{
    public enum currentInput
    {
        Button1_1,
        Button1_2,
        Button1_3,
        Button1_4,
        Button1_5,
        Button2_1,
        Button2_2,
        Button2_3,
        Button2_4,
        Button3_1,
        Button3_2,
        Button3_3,
        Button4_1,
        Button4_2,
        Button5_1,
        ButtonNotMapped
    }

    private currentInput _currentInput;
    private float inputDelayDuration = 0.2f;
    private bool isIgnoringInput;


    void Update()
    {
        if (Input.anyKeyDown) HandleInput(Input.inputString);
        else if (Input.GetKey("left")) HandleInput("left");
        else if (Input.GetKey("right")) HandleInput("right");
    }

    private void HandleInput(string value)
    {
        switch (value)
        {
            case "h":
                _currentInput = currentInput.Button1_1;
                break;

            case "m":
                _currentInput = currentInput.Button1_2;
                break;

            case "u":
                _currentInput = currentInput.Button1_3;
                break;

            case "j":
                _currentInput = currentInput.Button1_4;
                break;

            case "v":
                _currentInput = currentInput.Button1_5;
                break;

            case ",":
                _currentInput = currentInput.Button2_1;
                break;

            case "y":
                _currentInput = currentInput.Button2_2;
                break;

            case "k":
                _currentInput = currentInput.Button2_3;
                break;

            case "ù":
                _currentInput = currentInput.Button2_4;
                break;

            case "right":
                _currentInput = currentInput.Button4_1;
                break;

            case "left":
                _currentInput = currentInput.Button4_2;
                isIgnoringInput = false;
                break;

            default:
                _currentInput = currentInput.ButtonNotMapped;
                isIgnoringInput = true;
                break;
        }

        StartCoroutine(InputDelay());

        Debug.Log(_currentInput);
    }

    private IEnumerator InputDelay()
    {
        yield return new WaitForSeconds(inputDelayDuration);
    }
}
