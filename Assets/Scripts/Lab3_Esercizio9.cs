using UnityEngine;

public class Lab3_Esercizio9 : MonoBehaviour
{
    public int a = 0;
    public int b = 0;

    private int MinoreTra2()
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            //In caso di parità comunica b
            return b;
        }
    }

    void Start()
    {
        Debug.Log(MinoreTra2());
    }
}
