using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= maxHealth;
        if (health <= 0)
            
        {
            Destroy(gameObject);
        }
    }
}
    
