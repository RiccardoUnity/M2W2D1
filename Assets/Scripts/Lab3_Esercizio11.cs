using UnityEngine;

public class Lab3_Esercizio11 : MonoBehaviour
{
    public float voto = 0f;

    void Start()
    {
        if (voto >= 0f && voto <= 10f)   //Delimito l'insieme possinbile di voti
        {
            if (voto <= 4f)
            {
                Debug.Log("F");
            }
            else if (voto <= 5f)
            {
                Debug.Log("E");
            }
            else if (voto <= 6f)
            {
                Debug.Log("D");
            }
            else if (voto <= 7f)
            {
                Debug.Log("C");
            }
            else if (voto <= 8f)
            {
                Debug.Log("B");
            }
            else if (voto <= 9f)
            {
                Debug.Log("A");
            }
            else if (voto <= 10f)
            {
                Debug.Log("A+");
            }
            else
            {
                Debug.Log("Non dovrebbe mai comparire questa stringa, ma per sicurezza la metto");
            }
        }
        else
        {
            Debug.Log("Voto non valido");
        }
    }
}
