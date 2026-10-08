using UnityEngine;
using TMPro;
using System;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private Health playerHealth;


    // Update is called once per frame
    void Update()
    {
        healthText.text = Convert.ToString(playerHealth.currentHealth) + "/" + Convert.ToString(playerHealth.maxHealth);
    }
}
