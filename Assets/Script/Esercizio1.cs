using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    [SerializeField] int index = 5;
    [SerializeField] int num = 10;

    void Start()
    {
        while (index > 0) {

            ++num;
            Debug.Log(num);

            --index;
            Debug.Log(index);

        }
    }

}
