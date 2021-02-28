using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptSonido : MonoBehaviour
{
    public GameObject musica;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="tiburon")
        {
            musica.SetActive(true);
        }
    }

  
}
