using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    
    int somma = 0;
    int prodotto = 1;

    void Start()
    {   
        int[] numeri = new int[4];
        numeri[0] = 2;
        numeri[1] = 3;
        numeri[2] = 1;
        numeri[3] = 2;

        /*       i va ad iterare e sommare l'indice non il contenuto
        *
        *
        *        for (int i = 0; i < numeri.Length; i++)
        *        {
        *            somma += i;
        *        }
        *        Debug.Log(somma);
        */


        for (int i = 0; i < numeri.Length; i++)
        {
            somma += numeri[i];
        }
        Debug.Log(somma);

        for (int i = 0; i < numeri.Length; i++)
        {
            prodotto *= numeri[i];
        }
        Debug.Log(prodotto);

    }

 
}
