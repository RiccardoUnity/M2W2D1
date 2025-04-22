using UnityEngine;

public class Lab3_Esercizio8 : MonoBehaviour
{
    public int a = 0;
    public int b = 0;

    private int MaggioreTra2()
    {
        if (a < b)
        {
            return b;
        }
        else
        {
            //In caso di parità comunica a
            return a;
        }
    }

    void Start()
    {
        Debug.Log(MaggioreTra2());
    }
}
