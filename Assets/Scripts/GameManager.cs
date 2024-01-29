using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score = 0; // Score variable
    [SerializeField] private TextMeshProUGUI scoreText; // Reference to UI Text component for displaying the score

    // Other variables and methods...

    void Start()
    {
        // Initialize the score and update the display
        score = 0;
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay()
    {
        // Update the Text component to display the current score
        if (score >=13)
        {
            scoreText.text = "You win!";
        }
        else
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    void CollectCoin()
    {
        // Add to the score when the player collects a coin
        score += 1; // You can adjust the amount based on your game's design
        UpdateScoreDisplay();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            CollectCoin();
            Destroy(collision.gameObject); // Destroy the coin or handle its removal
        }
    }

    // Other methods and events...

    // Rest of your code
}