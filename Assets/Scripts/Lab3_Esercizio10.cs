using UnityEngine;

public class Lab3_Esercizio10 : MonoBehaviour
{
    private float tempoTrascorso = 0f;

    void Update()
    {
        tempoTrascorso += Time.deltaTime;

        if (tempoTrascorso < 30f)
        {
            Debug.Log("Sono trascorsi meno di 30 secondi");
        }
        else if (tempoTrascorso < 45f)
        {
            Debug.Log("Sono trascorsi più di 30 secondi");
        }
        else if (tempoTrascorso < 60f)
        {
            Debug.Log("Sono trascorsi più di 45 secondi");
        }
        else
        {
            Debug.Log("È trascorso più di un minuto");
        }

        //Potevo fare così oppure usare Time.realtimeSinceStartup rinunciando alla variabile ora in uso
    }
}
