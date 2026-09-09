using UnityEngine;

public class LevelUpScreen : MonoBehaviour
{
    public bool lvlScreen;

    private void Awake()
    {
        LevelScreenInactive();
        lvlScreen = false;
    }

    public void LevelScreenActive()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void LevelScreenInactive()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void option1()
    {
        Debug.Log("Option 1");
        LevelScreenInactive();

    }
    public void option2()
    {
        Debug.Log("Option 2");
        LevelScreenInactive();
    }
    public void option3()
    {
        Debug.Log("Option 3");
        LevelScreenInactive();
    }
}
