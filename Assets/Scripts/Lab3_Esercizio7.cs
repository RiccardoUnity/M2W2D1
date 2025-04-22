using UnityEngine;

public class Lab3_Esercizio7 : MonoBehaviour
{
    public int partenza = 0;

    //Volevo scrivere tutti i numeri sullo stesso messaggio del Debug.Log
    private string Stampa2Precedenti()
    {
        return partenza.ToString() + ", " + (partenza-1).ToString() + ", " + (partenza-2).ToString();
    }

    void Start()
    {
        Debug.Log(Stampa2Precedenti());
    }
}
