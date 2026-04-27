using Unity.VisualScripting;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public GameObject difficultyPanel;
    public int maxAttempts;

    public static Difficulty instance;

    public void Awake()
    {
        instance = this;
    }

    void Start()
    {
        AudioManager.instance.PlaySFX(0);
    }


    void Update()
    {

    }
    

    public void Easy()
    {
        AudioManager.instance.PlaySFX(1);
        GameController.instance.targetNumber = Random.Range(1, 26);
        maxAttempts = 5;
        GameController.instance.attemptsLeft = maxAttempts;
        GameController.instance.UpdateUI("Guess a number between 1 and 25!");
        GameController.instance.inputField.ActivateInputField();

    }

    public void Normal()
    {
        AudioManager.instance.PlaySFX(1);
        GameController.instance.targetNumber = Random.Range(1, 51);
        maxAttempts = 5;
        GameController.instance.attemptsLeft = maxAttempts;
        GameController.instance.UpdateUI("Guess a number between 1 and 50!");
        GameController.instance.inputField.ActivateInputField();
    }

    public void Hard()
    {
        AudioManager.instance.PlaySFX(1);
        GameController.instance.targetNumber = Random.Range(1, 101);
        maxAttempts = 5;
        GameController.instance.attemptsLeft = maxAttempts;
        GameController.instance.UpdateUI("Guess a number between 1 and 100!");
        GameController.instance.inputField.ActivateInputField();
    }

    public void Execute()
    {
        Destroy(difficultyPanel);
    }


}
