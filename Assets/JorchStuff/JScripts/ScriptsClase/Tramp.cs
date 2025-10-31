using UnityEngine;

public class Tramp : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Vector3 direccionInicial;

    private Vector3 direccionActual;

    private float timer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direccionActual = direccionInicial;
    }

    // Update is called once per frame
    void Update()
    {
        //Haz que vaya y vuelva cada 2 segundos
        
        
        timer += 1 * Time.deltaTime;
        Debug.Log(timer);
        //transform.Translate(new Vector3(1, 0, 0) * 2 * Time.deltaTime, Space.World);
        transform.Translate(direccionActual * velocidad * Time.deltaTime, Space.World);
        
        //En cuanto se pase el timer de 2...
        if (timer >= 2f)
        {
            direccionActual *= -1f;
            timer = 0;
        }
    }
}
