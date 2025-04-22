using UnityEngine;

public class Lab3_Esercizio3 : MonoBehaviour
{
    void Start()
    {
        //Eseguito solo una volta
        Debug.Log("Ci sono 2 modi per esporre una variabile nell'inspector:");
        Debug.Log("1 - rendere la variabile public");
        Debug.Log("2 - inserire l'attributo [SerializeField] prima della variabile privata o protected");
    }

    /*
    void Update()
    {
        Qua lo inserisco comentato
        Ci sono 2 modi per esporre una variabile nell'inspector:
        1 - rendere la variabile public
        2 - inserire l'attributo [SerializeField] prima della variabile privata o protected
        Debug.Log("Hello World");
    }
    */
}
