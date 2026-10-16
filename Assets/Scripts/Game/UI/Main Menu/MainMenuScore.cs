using System;
using TMPro;
using UnityEngine;

public class MainMenuScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highScore;
    private int loadedHighScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        LoadScore();
        highScore.text = Convert.ToString(loadedHighScore);
    }

    public void LoadScore()
    {
        loadedHighScore = PlayerPrefs.GetInt("HighScore");
    }
}
