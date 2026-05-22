using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour

{
    public float timeRemaining = 30f;
    public TextMeshProUGUI timerText;
    public GameObject gameOverPanel; 
    void Update()
    {
        if (timeRemaining > 0)
        {
            // Subtract the time passed since the last frame
            timeRemaining -= Time.deltaTime;
            
            timerText.text = $"00:{timeRemaining:00}"; 
        }
        else
        {
            timeRemaining = 0;
            timerText.text = "0";
            
            // This runs the function below
            TriggerGameOver(); 
        }
    }

    void TriggerGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
