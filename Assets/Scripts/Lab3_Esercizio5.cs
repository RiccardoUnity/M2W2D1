using UnityEngine;

public class Lab3_Esercizio5 : MonoBehaviour
{
    public int numero = 0;
    private string debugString;

    void Start()
    {
        //Controllo se pari o dispari
        if (numero % 2  == 0)
        {
            debugString = "Pari";
        }
        else
        {
            debugString = "Dispari";
        }

        //Controllo se maggiore di 10
        if (numero > 10)
        {
            debugString += " , maggiore di 10";
        }
        /* Non richiesto dalla consegna
        else
        {
            debugString += "minore o uguale di 10";
        }
        */

        //Comunico il risultato
        Debug.Log(debugString);
    }
}
