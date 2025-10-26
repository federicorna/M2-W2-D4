using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    [SerializeField] int num = 30;


    void Start()
    {
        for (int i = 1; i <= num; i++)

            if (i % 3 == 0 && i % 5 == 0)
            {

                Debug.Log(i + "FizzBuzz");

            }
            else if (i % 3 == 0)
            {

                Debug.Log(i + "Fizz");

            }
            else if (i % 5 == 0)
            {

                Debug.Log(i + "Buzz");
            }
            else {

                Debug.Log(i);
            
            }
        
    }


}
