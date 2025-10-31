using UnityEngine;

public class Door : MonoBehaviour
{
    public float DoorMovement = 3f;
    public float DoorSpeed = 2f;
    private bool isOpening = false;
    private Vector3 posicionInicial;
    private Vector3 posicionFinal;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isOpening = false;
        posicionInicial = transform.position;
        posicionFinal = posicionInicial + Vector3.up * DoorMovement;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpening)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionFinal, Time.deltaTime * DoorSpeed);
        }
    }

    public void OpenDoor()
    {
        isOpening = true;
    }
}
