﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptCamara : MonoBehaviour
{
    public GameObject jugador;
    Vector3 distancia;
    //Rigidbody miRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        distancia = transform.position- jugador.transform.position ;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = jugador.transform.position + distancia;
       
    }
    
        
    
}
