using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Data/Player/Stats")]
public class PlayerBaseStats : ScriptableObject
{
    [SerializeField] private float baseHealth;
    [SerializeField] private float baseSpeed;
    [SerializeField] private float baseStrength;

}
