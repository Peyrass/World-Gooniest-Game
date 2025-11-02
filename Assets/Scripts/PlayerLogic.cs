using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour
{
    private PlayerMovement playerMovement;
        [SerializeField] private TMP_Text ScoreText;
    public int orbs;
    public Door door; 
    public AudioSource AudioSource;
    public AudioClip OrbSound;
    public AudioClip DeathSound;
    

    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }
    void Update()
    {
        if (orbs == 3) //Al cumplirse se abre la puerta
        {
            door.OpenDoor();
        }
    }
    
    //Interacción tipo Trigger (A y B)
    
    //OBLIGATORIO: Ambos gameObjects deben tener COLLIDER
    //OBLIGATORIO: Uno de los colliders debe ser Trigger (atravesable)
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Trap"))
        {
            AudioSource.PlayOneShot(DeathSound);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        else if (other.gameObject.CompareTag("Finish"))
        {
            int ThisScene =  SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(ThisScene + 1);
        }
        
        else if (other.gameObject.CompareTag("Size"))
        {
            transform.localScale *= 0.3f; //= new Vector3(0.3f, 0.3f, 0.3f)
            Destroy(other.gameObject);
        }
        
        else if (other.gameObject.CompareTag("Points"))
        {
            Destroy(other.gameObject);
            orbs ++;
            ScoreText.text = "Score: " + orbs;
            AudioSource.PlayOneShot(OrbSound);
            Debug.Log(orbs);
        }
    }
}
