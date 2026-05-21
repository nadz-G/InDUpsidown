using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") &&
            other.TryGetComponent(out PlayerHealth playerHealth))
        {
            Debug.Log("Player damaged" + playerHealth);
            playerHealth.TakeDamage(damage);
            Debug.Log(playerHealth);
        }
    }
}