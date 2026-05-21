using UnityEngine;
using UnityEngine.UI; 

public class PlayerHealth : MonoBehaviour
{
    //public int maxHealth = 3;
    public int health = 3;
    [Header("UI Hearts")]
    public Image[] hearts;
    
    public float invincibilityTime = 2f;
    private float invincibleUntil = -1;
    
    void Start()
    {
        UpdateHeartsUI();
        Debug.Log(health);
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
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(health);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("I have been hit"); //trying to see if the collision is working
            TakeDamage(1);
        }
    }*/
}