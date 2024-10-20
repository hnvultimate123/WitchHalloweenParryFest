using UnityEngine;

public class Quit : MonoBehaviour
{
    // This method will be called when the Quit button is clicked
    public void QuitGame()
    {
        // Exit the game
        Debug.Log("Game is quitting");
        Application.Quit();
    }
}