using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float frequency = 1f;  // turn direction speed 
    public float distance = 7f;   // How far left/right it goes
    public float speed = 2f;      // speed

    void Update()
    {
        myRigidbody.linearVelocityX = Mathf.Sin(Time.time * frequency) * distance * speed;
    }
}