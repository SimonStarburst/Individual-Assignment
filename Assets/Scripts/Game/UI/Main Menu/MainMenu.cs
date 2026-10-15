using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void NewGame()
    {
        SceneManager.LoadScene("Level1");  // Loads the the game scene
    }

    public void Options()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
