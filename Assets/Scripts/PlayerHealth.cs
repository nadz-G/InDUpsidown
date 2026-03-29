using UnityEngine;
using UnityEngine.UI; 

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;

    [Header("UI Hearts")]
    public Image[] hearts;

    void Start()
    {
        health = maxHealth;
        UpdateHeartsUI();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        
        UpdateHeartsUI();

        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Player Destroyed!");
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