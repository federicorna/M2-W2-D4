using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    [SerializeField] int numberToFind = 5;
    [SerializeField] int arraySize = 15;
    [SerializeField] int offset = 10;

    void Start()
    {
        int[] numeri = new int [arraySize];
        int min = numberToFind - offset;
        int max = numberToFind + offset;
        int number = 0;

        if (numberToFind - offset < 0)
        {
            min = 0;
        }

        for (int i = 0; i < numeri.Length; i++)
        {
            numeri[i] = Random.Range(min, max);
            ++number;

            if (numeri[i] == numberToFind)
            {
                Debug.Log("Iteration number " + number + " (number to find = " + numeri[i] + "): " + " found");
                break;
            } 
            else
            {
                Debug.Log("Iteration number " + number + " (numbert to find = " + numeri[i] + "): " + " not found");
            }
        }

        Debug.Log("Iteration finished");

    }


}
