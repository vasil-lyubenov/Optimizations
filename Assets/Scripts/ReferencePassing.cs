using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferencePassing : MonoBehaviour
{
    private float random;

    public struct Person
    {
        public float age;
        public string name;

        public void BreakBoardInHalf(float bordLength)
        {
            Debug.Log(bordLength);
        }
    }

    private void Start()
    {
        float woodBoard = 2f;
        Person karateKid = new Person();

        karateKid.BreakBoardInHalf(woodBoard);

        Debug.LogFormat("The length of the board is: {0}", woodBoard);
    }
}
