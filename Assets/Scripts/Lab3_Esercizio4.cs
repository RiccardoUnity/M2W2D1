using UnityEngine;

public class Lab3_Esercizio4 : MonoBehaviour
{
    public float numero1 = 0f;
    public float numero2 = 0f;
    public float numero3 = 0f;
    public float numero4 = 0f;

    void Start()
    {
        Debug.Log("Somma: " + (numero1 + numero2 + numero3 + numero4));
        Debug.Log("Prodotto: " + (numero1 * numero2 * numero3 * numero4));
        Debug.Log("Media: " + (numero1 + numero2 + numero3 + numero4) / 4f);
    }
}
