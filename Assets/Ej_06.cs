using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_06 : MonoBehaviour
{
    //public int Num1 => 0;
    public int num1;
    // Start is called before the first frame update
    void Start()
    {
        int resto = num1 % 2;
        if (resto == 0)
        {
            Debug.Log("El  número es par");
        }
        else
        {
            Debug.Log("El numero es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
