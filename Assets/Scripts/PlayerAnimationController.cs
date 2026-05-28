using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator anim;
    
    public float gameTimer = 60f; // 60-second countdown
    private bool timerEnded = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
     
        if (!timerEnded)
        {
            if (gameTimer > 0)
            {
                gameTimer -= Time.deltaTime;
            }
            else
            {
                EndGameTimeUp();
            }
        }
    }

    // triggers damage 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") && !timerEnded)
        {
            // Turn the damage bool ON
            anim.SetBool("damage", true);
            
            // Delete the bird so it doesn't stay on screen
            Destroy(other.gameObject);
            
            // Tell Unity to turn the damage animation OFF after a brief moment (e.g., 0.3 seconds)
            Invoke("ResetDamageBool", 0.3f);
        }
    }

    void ResetDamageBool()
    {
        anim.SetBool("damage", false);
    }

    
    void EndGameTimeUp()
    {
        timerEnded = true;
        gameTimer = 0;
        anim.SetBool("isGameOver", true);
        
        Debug.Log("Time is up! Player is falling down!");
    }
}