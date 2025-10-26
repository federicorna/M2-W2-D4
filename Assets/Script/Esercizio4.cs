using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    [SerializeField] int startNumber = 3;
    [SerializeField] int amount = 5;
    void Start()
    {
        for (int i = 0; i <= amount; i++)
        {
            Debug.Log(startNumber + i);
        }
    }


}
