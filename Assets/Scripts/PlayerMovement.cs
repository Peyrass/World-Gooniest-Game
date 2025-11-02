using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] public float Speed;
    private Vector3 InitPossition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitPossition = transform.position;
    }

    // Update is called once per frame
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
        transform.Translate(movementDirection * (Speed * Time.deltaTime), Space.World);
    }
}
