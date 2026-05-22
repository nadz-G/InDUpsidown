using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    [Header("UI Hearts")]
    public Image[] hearts;
    
    public float invincibilityTime = 2f;
    private float invincibleUntil = -1;
    
    [Header("Scene Management")]
    public string gameOverSceneName = "GameOver";
    
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
            // load the Game Over scene
            SceneManager.LoadScene(gameOverSceneName);
        }
    }

    void UpdateHeartsUI()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}