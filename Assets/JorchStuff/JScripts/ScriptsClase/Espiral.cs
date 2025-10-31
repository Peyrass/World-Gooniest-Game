using UnityEngine;

public class Espiral : MonoBehaviour
{
    //Se declaran las variables
    [SerializeField] private float velocidadRotacion;
    [SerializeField]  private Vector3 direccionRotacion;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * (velocidadRotacion * Time.deltaTime), Space.World);
    }
}
