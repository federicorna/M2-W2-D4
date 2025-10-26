using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsercizioTab5 : MonoBehaviour
{
    [SerializeField] int num = 5;

    void Start()
    {
        for (int i = 0; i <= 10; i++) {

            Debug.Log(num * i);

        }

    }

}