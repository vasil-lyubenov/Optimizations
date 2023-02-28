using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAlphaHit : MonoBehaviour
{
    public Image button; 

    void Start()
    {
        button.alphaHitTestMinimumThreshold = 0.5f;
    }

    public void OnPress()
    {
        Debug.LogError("Hello");
    }
}
