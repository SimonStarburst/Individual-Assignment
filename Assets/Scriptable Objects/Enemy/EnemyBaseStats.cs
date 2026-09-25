using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "Data/Enemy/Stats")]
public class EnemyBaseStats : ScriptableObject
{
    public float baseHealth;
    public float baseSpeed;
    public float baseStrength;

}