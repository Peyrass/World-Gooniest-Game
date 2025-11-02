using UnityEngine;

public class Door : MonoBehaviour
{
    public float DoorMovement = 4f;
    public float DoorSpeed = 4f;
    private bool isOpening = false;
    private Vector3 InitDoorPosition;
    private Vector3 FinalDoorPosition;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isOpening = false;
        InitDoorPosition = transform.position;
        FinalDoorPosition = InitDoorPosition + Vector3.up * DoorMovement;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpening)
        {
            transform.position = Vector3.MoveTowards(transform.position, FinalDoorPosition, Time.deltaTime * DoorSpeed);
        }
    }

    public void OpenDoor()
    {
        isOpening = true;
    }
}
