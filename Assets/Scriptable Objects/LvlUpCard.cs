using System;
using UnityEngine;

public enum LevelUpUpgrade
{
    BaseWeapon,
    WeaponUpgrade,
    PlayerUpgrade,
}

[CreateAssetMenu(fileName = "LvlUpCard", menuName = "Data/LvlUpCard")]
public class LvlUpCard : ScriptableObject
{
    public LevelUpUpgrade levelUpUpgrade;
    public new string name;
    public string description;

    public Sprite lvlUpPicture;
}
