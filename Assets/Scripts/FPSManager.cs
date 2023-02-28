using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSManager : MonoBehaviour
{
    public TextMeshProUGUI fpsCounter;
    public float refreshRateTime = 1f;

    private float timeSinceLastRefresh;
    // Update is called once per frame
    void Update()
    {
        if (timeSinceLastRefresh <= refreshRateTime)
        {
            timeSinceLastRefresh += Time.unscaledDeltaTime;
            return;    
        }

        fpsCounter.text = ((int)(1f / Time.unscaledDeltaTime)).ToString();
        timeSinceLastRefresh = 0;
    }
}
