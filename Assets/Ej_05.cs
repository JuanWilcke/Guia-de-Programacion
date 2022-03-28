using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_05 : MonoBehaviour
{
    public float num1;
    public float num2;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        float resultado = num1 / num2;

        if (num2 == 0)
        {
            Debug.Log("No se puede dividir por 0");
        }
        else
        {
            Debug.Log(resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
