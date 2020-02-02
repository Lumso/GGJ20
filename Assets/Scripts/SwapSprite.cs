using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapSprite : MonoBehaviour
{
    public Sprite spriteOn;
    public Sprite spriteOff;
    public float swapSpriteInterval = 2f;

    private Image currentSprite;
    


    void Start()
    {
        currentSprite = this.GetComponent<Image>();
        StartCoroutine(SwapSpriteContent());
    }


    private IEnumerator SwapSpriteContent()
    {
        while(true)
        {
            yield return new WaitForSeconds(swapSpriteInterval);
            if (currentSprite.sprite == spriteOff) currentSprite.sprite = spriteOn;
            else if (currentSprite.sprite == spriteOn) currentSprite.sprite = spriteOff;
        }
    }
}
