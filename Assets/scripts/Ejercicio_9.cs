using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad.
//Se desea saber qué porcentaje del  total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres. 
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 


public class Ejercicio_9 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float capital1;
    public float capital2;
    public float capital3;
    // Start is called before the first frame update
    void Start()
    {
        float capitaltotal = capital1 + capital2 + capital3;
        float porcentaje1 = capital1 * 100 / capitaltotal;
        float porcentaje2 = capital2 * 100 / capitaltotal;
        float porcentaje3 = capital3 * 100 / capitaltotal;
        Debug.Log("El total aportado es de" + capitaltotal + "pesos");
        Debug.Log(nombre1 + " Aporto" + capital1 + "pesos." + "El porcentaje de la capital es de" + porcentaje1 + "% del capital");
        Debug.Log(nombre2 + " Aporto" + capital2 + "pesos." + "El porcentaje de la capital es de" + porcentaje2  + "% del capital");
        Debug.Log(nombre3 + " Aporto" + capital3 + "pesos." + "El porcentaje de la capital es de" + porcentaje3 + "% del capital");
    }
}
