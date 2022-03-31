using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_07 : MonoBehaviour
{
    public int num1; 
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2 && num1 > num3)
        {
            Debug.Log("El mayor es el número 1 y su valor es" + num1);
        }
        if (num2 > num1 && num2 > num3)
        {
            Debug.Log("El mayor es el número 2 y su valor es" + num2);
        }
        if (num3 > num1 && num3 > num2)
        {
            Debug.Log("El mayor es el número 3 y su valor es" + num3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
