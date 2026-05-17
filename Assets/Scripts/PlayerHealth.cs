using UnityEngine;
using UnityEngine.UI; 

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;

    [Header("UI Hearts")]
    public Image[] hearts;
    
    public float invincibilityTime = 2f;
    private float invincibleUntil = -1;
    
    void Start()
    {
        health = maxHealth;
        UpdateHeartsUI();
    }
    public void TakeDamage(int damage)
    {
        if (Time.time < invincibleUntil)
        {
            return; // no damage - invincible
        }
        
        health -= damage;
        
        UpdateHeartsUI();
        invincibleUntil = Time.time + invincibilityTime;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    // heart viability 
    void UpdateHeartsUI()
    {
        for (int i = 0; i < hearts.Length; i++) // ( i is <3)
        {
            // If the heart 
            
            if (i < health)
            {
                hearts[i].enabled = true;
            }
            else
            {
                // Otherwise, hide it
                hearts[i].enabled = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
}