using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.InputSystem;

public class GameMenu : MonoBehaviour
{
    [SerializeField] GameObject panel;
    PauseManager pauseManager;

    private void Awake()
    {
        pauseManager = GetComponent<PauseManager>();
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Pause();
    }

    void Pause()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (panel.activeInHierarchy == false)
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }

        }
    }

    public void OpenMenu()
    {
        pauseManager.PauseGame();
        panel.SetActive(true);
    }

    public void CloseMenu()
    {
        pauseManager.UnpauseGame();
        panel.SetActive(false);
    }

}
