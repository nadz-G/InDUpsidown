using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    [Header("Health")]
    public int health = 3;

    [Header("UI Hearts")]
    public Image[] hearts;

    [Header("Invincibility")]
    public float invincibilityTime = 2f;
    private float invincibleUntil = -1f;

    [Header("Scene Management")]
    public string gameOverSceneName = "GameOver";

    private SpriteRenderer spriteRenderer;
    private Coroutine flashCoroutine;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateHeartsUI();
    }

    public void TakeDamage(int damage)
    {
        // If invincible, ignore damage
        if (Time.time < invincibleUntil)
            return;

        health -= damage;
        UpdateHeartsUI();

        invincibleUntil = Time.time + invincibilityTime;

        // Restart flashing if already running
        if (flashCoroutine != null)
            StopCoroutine(flashCoroutine);

        flashCoroutine = StartCoroutine(FlashSprite());

        if (health <= 0)
        {
            SceneManager.LoadScene(gameOverSceneName);
        }
    }

    IEnumerator FlashSprite()
    {
        float elapsed = 0f;
        float flashInterval = 0.1f;

        while (elapsed < invincibilityTime)
        {
            spriteRenderer.enabled = false;
            yield return new WaitForSeconds(flashInterval);

            spriteRenderer.enabled = true;
            yield return new WaitForSeconds(flashInterval);

            elapsed += flashInterval * 2f;
        }

        // makes sure sprite is visible when invincibility ends
        spriteRenderer.enabled = true;
    }

    void UpdateHeartsUI()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].enabled = i < health;
        }
    }
}