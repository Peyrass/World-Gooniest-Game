using UnityEngine;

public class Espiral : MonoBehaviour
{
    //Se declaran las variables
    [SerializeField] private float Torque;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * (Torque * Time.deltaTime), Space.World);
    }
}
