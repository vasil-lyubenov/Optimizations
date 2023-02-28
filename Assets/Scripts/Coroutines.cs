using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    public float waitForSeconds = 3f;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(waitForSeconds);

        Debug.Log("Stating Coroutine function after delay!");
    }
}
