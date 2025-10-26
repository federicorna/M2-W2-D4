using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopiaEs2 : MonoBehaviour
{
    int sottrazione = 10;
    int divisione = 20;

    void Start()
    {
        int [] array = new int [2];
        array [0] =5;
        array [1] = 2;

        for (int i = 0; i < array.Length; i++)
        {
            sottrazione -= array [i];
        }
        Debug.Log(sottrazione);

        for (int i = 0; i < array.Length; i++)
        {
            divisione /= array[i];
        }
        Debug.Log(divisione);
    }

 
}
