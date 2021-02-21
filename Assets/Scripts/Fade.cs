using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{

    public Image whiteImage;

    
    private void Start()
    {
        whiteImage.canvasRenderer.SetAlpha(0);
        FadeIn();
    }

    private void FadeIn()
    {
        whiteImage.CrossFadeAlpha(1f,1f, false);
    }
}
