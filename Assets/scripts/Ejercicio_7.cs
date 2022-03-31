using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y  num3
//muestre el valor del mayor de todos. 
//En caso de igualdad entre los tres imprimir "Los números son iguales".


public class Ejercicio_7 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2 && num1 > num3)
        {
            Debug.Log("El mayor numero es " + num1);
        }
        if (num2 > num1 && num2 > num3)
        {
            Debug.Log("El mayor numero es " + num2);
        }
        if (num3 > num1 && num3 > num2)
        {
            Debug.Log("El mayor numero es " + num3);
        }
        if (num1 == num2 && num2 == num3)
        {
            Debug.Log("Los tres numeros son iguales");
        }
    }
}
        
