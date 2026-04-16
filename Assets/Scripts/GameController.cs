using TMPro;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI feedbackText;
    public TextMeshProUGUI attemptsText;
    public GameObject restartButton;
    public GameObject submitButton;

    public int targetNumber;
    private int attemptsLeft;
    public int maxAttempts = 3;

    public static GameController instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        StartGame();
        inputField.ActivateInputField();
    }

    public void StartGame()
    {
        targetNumber = Random.Range(1, 11);
        attemptsLeft = maxAttempts;
        UpdateUI("Guess a number between 1 and 10!");
        inputField.interactable = true; 
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }



    public void OnSubmit()
    {
        if (int.TryParse(inputField.text, out int playerGuess))
        {
            if(playerGuess == targetNumber)
            {
                UpdateUI("Your Correct! The Number Was " + targetNumber);
                inputField.interactable = false;
                submitButton.SetActive(false);
                restartButton.SetActive(true);
            } 

            if (playerGuess < targetNumber)
            {
                inputField.ActivateInputField();
                attemptsLeft--;
                UpdateUI("Higher");
            }

            if (playerGuess > targetNumber)
            {
                inputField.ActivateInputField();
                attemptsLeft--;
                UpdateUI("Lower");      
            }

            if (attemptsLeft <= 0)
            {
                UpdateUI("GAME OVER! It was " + targetNumber);
                inputField.DeactivateInputField();
                inputField.interactable = false;
                submitButton.SetActive(false);
                restartButton.SetActive(true);
            }

        }
        inputField.text = ""; 
    }

    public void UpdateUI(string message)
    {
        feedbackText.text = message;
        attemptsText.text = "Attempts Left: " + attemptsLeft;
    }
}