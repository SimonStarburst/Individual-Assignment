using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.InputSystem;

public class GameMenu : MonoBehaviour
{
    [SerializeField] GameObject panel;




    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            panel.SetActive(true);
        }
    }

}
