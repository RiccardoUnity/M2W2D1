using System;
using UnityEngine;

public class Lab3_Esercizio4_Bonus : MonoBehaviour
{
    public float[] numero = new float[4];
    private float somma = 0f;
    private float prodotto = 1f;
    private float media = 0f;

    //Viene eseguito solo in Editor quando viene cambiata una variabile
    void OnValidate()
    {
        //Blocco la grandezza dell'array su 4 elementi
        if (numero.Length != 4)
            Array.Resize(ref numero, 4);
    }

    void Start()
    {
        //Eseguo tutte le operazioni
        foreach(float num in numero)
        {
            somma += num;
            prodotto *= num;
        }
        media = somma / numero.Length;

        //Comunico tutti i risultati
        Debug.Log("Somma: " + somma);
        Debug.Log("Prodotto: " + prodotto);
        Debug.Log("Media: " + media);
    }
}
