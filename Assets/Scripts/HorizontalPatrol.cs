using UnityEngine;

public class HorizontalPatrol : MonoBehaviour
{
    public float speed = 2f;
    public float walkTime = 3f; // how many seconds to walk in one direction
    
    private float timer;
    private int direction = 1; // 1 = Right, -1 = Left

    void Start()
    {
        timer = walkTime;
    }

    void Update()
    {
        
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);
        
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            // flip direction and reset timer
             direction *= -1;
            timer = walkTime;
            
            // enemy flips direction
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
}