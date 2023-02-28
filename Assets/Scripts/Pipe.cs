using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;

public class Pipe : MonoBehaviour
{
    public float moveAmount = 20f;
    public int loopAmount = 2000;

    RectTransform rectTrans;
    float resetPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        UpdatePipe();
    }

    private void Update()
    {
        rectTrans.offsetMin -= new Vector2(moveAmount * Time.deltaTime, 0);
        rectTrans.offsetMax = new Vector2(rectTrans.offsetMin.x, 0);
    }

    public void Initialize(float spawnPosition, float resetPosition)
    {
        rectTrans = GetComponent<RectTransform>();
        this.resetPosition = resetPosition;
        SetPosition(spawnPosition);
    }

    public void SetPosition(float newPosition)
    {
        rectTrans.offsetMin = new Vector2(newPosition, 0);
        rectTrans.offsetMax = new Vector2(-newPosition, 0);
    }

    async void UpdatePipe()
    {
        float newResetPosition = await Task<float>.Run(() =>
        {
            int i = 0;
            while(i++ < loopAmount)
            {
                Debug.Log("");
            }
            return resetPosition;
        });

        SetPosition(newResetPosition);
        // Reset pipes
    }
}
