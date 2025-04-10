using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta : MonoBehaviour
{
    public string codigoGusto;
    public int cantHelado;

    float precioPorKilo = 500;
    float precioTotal;

    // Start is called before the first frame update
    void Start()
    {
        if (cantHelado < 250 || cantHelado > 300)
        {
            Debug.Log("Cantidad de helado no válida.");
            return;
        }
        if (codigoGusto != "CHO" && codigoGusto != "DDL" && codigoGusto != "FRU")
        {
            Debug.Log("Código de helado no válido");
            return;
        }

        precioTotal = cantHelado * (precioPorKilo / 1000);

        if (codigoGusto == "FRU")
        {
            precioTotal = precioTotal * 0.1f;
        }

        Debug.Log("Debe pagar: " + precioTotal);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
