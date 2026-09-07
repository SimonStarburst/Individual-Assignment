using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void NewGame()
    {
        SceneManager.LoadScene(2);  // Loads the the game scene
    }

    public void Options()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
