using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public GameObject[] objectToDestroy;
    public float destroyDelay = 2f;

    void Start()
    {
        foreach (var go in objectToDestroy)
        {
            Destroy(go, destroyDelay);
        }
    }
}
