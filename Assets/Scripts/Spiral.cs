using UnityEngine;

public class Spiral : MonoBehaviour
{
    [SerializeField] private float Torque;
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * (Torque * Time.deltaTime), Space.World);
    }
}
