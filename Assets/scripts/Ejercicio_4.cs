using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////Realizá un programa que permita ingresar dos números enteros num1 y num2 por Inspector.
//Luego, mostrar el resultado de la suma entre ambos al ejecutar la escena utilizando el siguiente formato:
//“La  suma entre “ + num1 + “ y “ + num2 + “ da como resultado “ + num1 + num2. 

public class Ejercicio_4 : MonoBehaviour
   
{
    // Start is called before the first frame update
    public int num1,num2;
    void Start()
    {
        Debug.Log("La suma entre " + num1 + " y " + num2 + " da como resultado " + (num1 + num2));
    }

}
