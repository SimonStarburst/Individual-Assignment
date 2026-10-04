using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Data/Player/Stats")]
public class PlayerBaseStats : ScriptableObject
{
    [SerializeField] public int baseHealth;
    [SerializeField] public int baseSpeed;
    [SerializeField] public int baseStrength;

}
