using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class PipeController : MonoBehaviour
{
    public float displacementPosition;
    public Transform pipeParent;
    public float spawnStartingPosition;

    //Pooling fields
    [SerializeField]
    Pipe pipePrefab;
    [SerializeField]
    int poolAmount = 5;

    List<Pipe> pipes;

    void Start()
    {
        pipes = new List<Pipe>();
        for (int i = 0; i < poolAmount; i++)
        {
            pipes.Add(Instantiate(pipePrefab, pipeParent));
            pipes[i].Initialize(spawnStartingPosition + i * displacementPosition, spawnStartingPosition);
        }
    }
}
