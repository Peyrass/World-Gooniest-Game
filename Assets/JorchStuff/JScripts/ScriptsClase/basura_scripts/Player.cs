using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 posicionInicial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        posicionInicial = new Vector3(0, 0, 0);
        this.gameObject.transform.position = posicionInicial;
   
        Application.targetFrameRate = 30;
        
        //Establece una rotación en función de unos ángulos euler
       // this.gameObject.transform.rotation = Quaternion.Euler(0, 90, 45);
        this.gameObject.transform.eulerAngles = new Vector3(0, 50, 10);
        
        this.gameObject.transform.localScale = new Vector3(2, 2, 2);
        
        //Posicionarse a 3 unidades más en el eje Y desde donde está
        this.gameObject.transform.position += new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Posicionarse a 3 unidades más en el eje Y desde donde está
        this.gameObject.transform.position += new Vector3(0, 3f, 0) * Time.deltaTime;;
    }
}
             