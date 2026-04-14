using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI feedbackText;
    public TextMeshProUGUI attemptsText; // Shows "Lives: 3"

    private int targetNumber;
    private int attemptsLeft;
    public int maxAttempts = 3; // Set this in Inspector

    void Start()
    {
        RestartGame();
    }

    public void RestartGame()
    {
        targetNumber = Random.Range(1, 11);
        attemptsLeft = maxAttempts;
        UpdateUI("Guess a number between 1 and 10!");
        inputField.interactable = true; // Re-enable typing
    }

    public void OnSubmit()
    {
        if (int.TryParse(inputField.text, out int playerGuess))
        {
            if(playerGuess == targetNumber)
            {
                UpdateUI("Your Correct! The Number Was " + targetNumber);
                inputField.interactable = false;

            } 

            if (playerGuess < targetNumber)
            {
                UpdateUI("Higher");
                attemptsLeft--;
                if (attemptsLeft <= 0)
                {
                    UpdateUI("GAME OVER! It was " + targetNumber);
                    inputField.interactable = false; // Stop typing after loss
                }

            }
            if (playerGuess > targetNumber)
            {
                UpdateUI("Lower");
                attemptsLeft--;
                if (attemptsLeft <= 0)
                {
                    UpdateUI("GAME OVER! It was " + targetNumber);
                    inputField.interactable = false; // Stop typing after loss
                }

            }
     
        }
        inputField.text = ""; // Clear the box after each guess
    }

    void UpdateUI(string message)
    {
        feedbackText.text = message;
        attemptsText.text = "Attempts Left: " + attemptsLeft;
    }
}