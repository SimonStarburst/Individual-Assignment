using UnityEngine;
using TMPro;
using System;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private PlayerStats playerStats;


    // Update is called once per frame
    void Update()
    {
        healthText.text = Convert.ToString(playerStats.playerHP) + "/" + Convert.ToString(playerStats.maxHP);
    }
}
