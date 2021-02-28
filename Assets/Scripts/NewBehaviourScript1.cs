using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1 : MonoBehaviour
{
    
    public float velocidad = 5;
    int monedas = 0;
    
    Rigidbody miRigidbody;
    Vector3 posicionInicial;
    public Text tmonedas, ganaste;
    
    bool haSalido;
    public string siguienteEscena = " ";
    public AudioClip enemigos;
    public AudioClip moneda;
    public AudioClip victoria;
    AudioSource fuenteAudio;







    // Start is called before the first frame update
    void Start()
    {
        miRigidbody = GetComponent<Rigidbody>();
        posicionInicial = transform.position;
       
        //ganaste.enabled = false;
        
        miRigidbody.angularVelocity = Vector3.zero;
        miRigidbody.angularVelocity = Vector3.zero;

        ganaste.enabled = false;
        haSalido = false;
        //sonidos
        fuenteAudio = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()

    {
        if (!haSalido)
        {
            float vertical=Input.GetAxis("Vertical");
           float horizontal=Input.GetAxis("Horizontal");
            //miRigidbody.MovePosition(new Vector3(horizontal, 0, vertical) * velocidad*Time.deltaTime);
            miRigidbody.AddForce(new Vector3(horizontal, 0, vertical) * velocidad);
            miRigidbody.angularVelocity = Vector3.zero;
            ganaste.enabled = false;
        }





    }
    

    //es para las colisiones
    private void OnTriggerEnter(Collider other)
    {
       

        if (other.CompareTag("salida")) 

        {
            haSalido = true;
                  
            miRigidbody.angularVelocity = Vector3.zero;
            miRigidbody.velocity = Vector3.zero;
            //LoadScene(siguienteEscena);
            SceneManager.LoadScene("victoria");
            
            
           

        }
        else if (other.CompareTag("enemigo"))

        {
            miRigidbody.MovePosition(posicionInicial);

            
            miRigidbody.angularVelocity = Vector3.zero;

            miRigidbody.velocity = Vector3.zero;
            monedas = monedas;

            
            tmonedas.text = "Número de monedas: "+ monedas+"/25";
            
            //if (other.CompareTag("enemigo"))

            //{
            //    //sonidos
            //    fuenteAudio.clip = enemigos;
            //    fuenteAudio.Play();

            //}


            }
        else if (other.CompareTag("muro"))

        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            
            miRigidbody.angularVelocity = Vector3.zero;
            miRigidbody.angularVelocity = Vector3.zero;
            miRigidbody.MovePosition(new Vector3(horizontal, 0, vertical) * velocidad * Time.deltaTime);




        }
        else if (other.CompareTag("moneda"))

        {
            
            miRigidbody.angularVelocity = Vector3.zero;
           
            other.gameObject.SetActive(false);
            monedas = monedas + 1;
            tmonedas.text = "Número de monedas: " + monedas+"/25";
            
        }
    }
}
