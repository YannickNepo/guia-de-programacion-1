﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crear una variable entera que pueda ser modificada desde el Inspector.
//Suponiendo que el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al valor de la variable “dia”.
//Si el día no está en el rango  permitido debe emitir por pantalla el mensaje de error "El día ingresado no es válido".

public class Ejercicio_8 : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {
        //if (dia == 1)
        //{
        //    Debug.Log("El día es domingo");
        //}
        //else if (dia == 2)
        //{
        //    Debug.Log("El día es lunes");
        //}
        //else if (dia == 3)
        //{
        //    Debug.Log("El día es martes");
        //}
        //else if (dia == 4)
        //{
        //    Debug.Log("El día es miercoles");
        //}
        //else if (dia == 5)
        //{
        //    Debug.Log("El día es jueves");
        //}
        //else if (dia == 6)
        //{
        //    Debug.Log("El día es viernes");
        //}
        //else if (dia == 7)
        //{
        //    Debug.Log("El día es sabado");
        //}
        //else
        //{
        //    Debug.Log("El dia ingresado no es valido");
        //}

        switch (dia)
        {
            case 1:
                Debug.Log("El dia es domingo");
                break;
            case 2:
                Debug.Log("El dia es lunes");
                break;
            case 3:
                Debug.Log("El dia es martes");
                break;
            case 4:
                Debug.Log("El dia es miercoles");
                break;
            case 5:
                Debug.Log("El dia es jueves");
                break;
            case 6:
                Debug.Log("El dia es viernes");
                break;
            case 7:
                Debug.Log("El dia es sabado");
                break;
            default:
                Debug.Log("El dia ingresado no es valido");
                break;

        }

    }

    
}
