using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    // 1. Declaración de variables
    public string gustosHelado;
    public int gramos;
    float promocion = 0.1f;
    float costoTotal;
    float costoFru;
    int costoDDLyCHO;

    // Start is called before the first frame update
    void Start()
    {
        // 2 . ingreso y validación de datos
        if (gustosHelado != "CHO" && gustosHelado != "FRU" && gustosHelado != "DDL" || gramos < 250 || gramos > 3000)
        {
            Debug.Log("El gusto o los gramos ingresados son inválidos.");
            return;
        }
        if (gustosHelado == "CHO" || gustosHelado == "DDL" && gramos > 250 && gramos < 3000)
        {
            costoTotal = (gramos * 500) / 1000;
            
        }
        else
        {
            costoTotal = gramos * 500 / 1000 * promocion;

        }

        // 3. Procesamiento de datos

        // 4. Salida de datos
        Debug.Log("El costo de su pedido es: " + costoTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
