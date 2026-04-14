using TMPro;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public TMP_InputField myInputField; // Drag your InputField here in Inspector

    public void ReadNumber()
    {
        // Get whatever the player typed as a string
        string playerInputString = myInputField.text;

        // Convert the string to a real number (int)
        if (int.TryParse(playerInputString, out int playerNumber))
        {
            Debug.Log("The player typed: " + playerNumber);

            // You can now use 'playerNumber' to compare with your random number!
        }
        else
        {
            Debug.Log("The input box is empty or invalid.");
        }
    }
}
