using UnityEngine;
using UnityEngine.Serialization;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float frequency = 1f; // how quickly it changes direction
    public float direction = 7; // distance to left/right 


    // Update is called once per frame
    void Update()
    {
        myRigidbody.linearVelocityX = Mathf.Sin(Time.time * frequency) * direction;
    }
}
