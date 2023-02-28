using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class AsyncAwait : MonoBehaviour
{
    public int delayTimeMilliseconds = 3000;

    // Start is called before the first frame update
    async void Start()
    {
        await Task.Delay(delayTimeMilliseconds);

        Debug.Log("Stating Async function after delay!");
    }
}
