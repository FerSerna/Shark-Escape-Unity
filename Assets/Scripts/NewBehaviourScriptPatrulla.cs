using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptPatrulla : MonoBehaviour
{
    public Transform desde;
    public Transform hasta;
    public float velocidad;
    bool llendo;


    // Start is called before the first frame update
    void Start()
    {
        llendo = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 objetivo;
        if (llendo)
        {
            objetivo = hasta.position;
        }
        else
        {
            objetivo = desde.position;
        }

        Vector3 distancia = objetivo - transform.position;
        //calculando cuanto nos vamos a desplazar
        Vector3 desplazamiento = distancia.normalized * velocidad * Time.deltaTime;

        if (desplazamiento.sqrMagnitude >= distancia.sqrMagnitude)
        {
            desplazamiento = distancia;
            

        }
        transform.position = transform.position + desplazamiento;

        if (desplazamiento.sqrMagnitude <0.00001)
        {
            llendo = !llendo;


        }

    }
}
