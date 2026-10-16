using System;
using TMPro;
using UnityEngine;

public class EXPUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI expText;
    [SerializeField] private LevelUpManager playerEXP;


    // Update is called once per frame
    void Update()
    {
        expText.text = Convert.ToString(playerEXP.playerEXP) + "/" + Convert.ToString(playerEXP.toNextLevel);
    }
}
