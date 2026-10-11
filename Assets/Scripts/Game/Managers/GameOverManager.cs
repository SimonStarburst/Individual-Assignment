using UnityEngine;

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

}
