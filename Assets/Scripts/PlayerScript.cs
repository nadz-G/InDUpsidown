using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    
    public int direction = 1; // left/right direction
    public int speed = 3; // player speed (left/right)
    public float maxFallSpeed = 10;
    
    // Update is called once per frame
    void Update()
    { 
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            direction = direction * -1;
        }
        
        myRigidbody.linearVelocityX = speed * direction;
    }

    private void FixedUpdate()
    {
        Debug.Log(myRigidbody.linearVelocityY);
        myRigidbody.linearVelocityY = Mathf.Max(myRigidbody.linearVelocityY, maxFallSpeed);
    }
}
