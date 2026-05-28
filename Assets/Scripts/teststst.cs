using UnityEngine;

public class teststst : MonoBehaviour
{
  
        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("TRIGGER DETECTED WITH: " + other.name);
        }
    }