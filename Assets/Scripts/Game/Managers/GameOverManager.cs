using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] private PauseManager pauseManager;
    [SerializeField] private EnemyManager enemyManager;


    private void Awake()
    {
        panel.SetActive(false);
    }

    public void GameOver()
    {
        pauseManager.PauseGame();
        panel.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void QuitButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

}
