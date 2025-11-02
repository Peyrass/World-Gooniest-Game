using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] float ESpeed;
    [SerializeField] Vector3 InitDirection;
    [SerializeField] private float LoopTime;

    private Vector3 CurrentDirection;

   private float timer;
   
    void Start()
    {
        CurrentDirection = InitDirection;
    }
    
    void Update()
    {
        timer += 1 * Time.deltaTime;
        Debug.Log(timer);
        transform.Translate(CurrentDirection * ESpeed * Time.deltaTime, Space.World);
        
        if (timer >= LoopTime)
        {
            CurrentDirection *= -1f;
            timer = 0;
        }
    }
}
