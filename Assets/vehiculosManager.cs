using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehiculosManager : MonoBehaviour
{
    public Vehiculo vehiculoScript;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cantidad de Ruedas: " + vehiculoScript.cantRuedas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
