using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private float PSpeed;
    private Vector3 InitPossition;
    void Start()
    {
        InitPossition = transform.position;
    }
    
    void Update()
    {
        Move();
    }

    void Move()
    {
        float hImput = Input.GetAxisRaw("Horizontal"); //-1, 0, 1
        float vImput = Input.GetAxisRaw("Vertical"); //-1, 0, 1
        Debug.Log(hImput);
        Debug.Log(vImput);

        Vector3 movementDirection = new Vector3(hImput, vImput, 0f).normalized;
        transform.Translate(movementDirection * (PSpeed * Time.deltaTime), Space.World);
    }
}
