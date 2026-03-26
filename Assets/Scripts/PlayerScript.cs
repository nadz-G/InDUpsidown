using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    
    public int direction = 1; // left/right direction
    public int speed = 3; // player speed (left/right)
    
    // Update is called once per frame
    void Update()
    { 
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            direction = direction * -1;
        }
        
        myRigidbody.linearVelocityX = speed * direction;
    }
}
