using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    [SerializeField] private TMP_Text textoScore;
    private Vector3 posicionInicial; 
    int coins;
    public int keys;
    
    public Door door; //Asigna la puerta 
    
    public AudioSource AudioSource;
    public AudioClip sonidoLlave;
    public AudioClip sonidoMuerte;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //guardado de información
        posicionInicial = transform.position; // (-7.04, -0,61, 0);
    }
//tipo + nombre + valor
    // Update is called once per frame
    void Update()
    {
        Movimiento();

        if (keys == 0) //para que se abra la puerta cuando has recogido todas las llaves
        {
            door.OpenDoor();
        }
    }

    private void Movimiento()
    {
        float hImput = Input.GetAxisRaw("Horizontal"); //-1, 0, 1
        float vImput = Input.GetAxisRaw("Vertical"); //-1, 0, 1
        Debug.Log(hImput);
        
        //Variable tipo Vector3 que recoge los dos inputs anteriores y los normaliza
        Vector3 movementDirection = new Vector3(hImput, vImput, 0f).normalized;
        
        //2. Nos movemos en función del Vector3 del paso 1 a 3 unidades/s
        //this.gameObject.transform.position += movementDirection * (3 * Time.deltaTime);
        
        //Translate() para realizar traslaciones
        //this.gameObject.transform.Translate(movementDirection * (3f * Time.deltaTime));
        transform.Translate(movementDirection * (6f * Time.deltaTime), Space.World);
    }

    //Interacción tipo Trigger (A y B)
    //OBLIGATORIO ambos gameObjects con COLLIDER
    //OBLIGATORIO aquel que se mueve añadirle un Rigidbody (cinematico o dinamico)
    //Al menos un collider configurado como atravesable (TRIGGER)
    private void OnTriggerEnter2D(Collider2D other)
    {
        /*if (other.gameObject.CompareTag("Coin"))  //si el otro game object lleva el tag "Coin"...
        {
            Obtain_Coins(other);
        }*/
        
        if (other.gameObject.CompareTag("Trap"))
        {
            //transform.position = posicionInicial;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        else if (other.gameObject.CompareTag("Meta"))   //para pasar de nivel
        {
            int EscenaActual =  SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(EscenaActual + 1);
        }
        
        else if (other.gameObject.CompareTag("MiniSquare"))
        {
           // transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
           transform.localScale *= 0.5f;
            Destroy(other.gameObject);
        }
        
        else if (other.gameObject.CompareTag("Key"))
        {
            //other.GameObject("Puerta")
            Destroy(other.gameObject);
            keys --;
            coins++; //entonces coins++
            textoScore.text = "Keys: " + coins;
            AudioSource.PlayOneShot(sonidoLlave);
            Debug.Log(coins);
        }
            
    }

}
