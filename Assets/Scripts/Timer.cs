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
            
            timerText.text = Mathf.CeilToInt(timeRemaining).ToString(); 
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
         gameOverPanel.SetActive(true); 
         Time.timeScale = 0f; 
        Debug.Log("Time's Up!");
    }
}
