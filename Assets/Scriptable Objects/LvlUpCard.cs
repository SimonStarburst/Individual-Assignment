using UnityEngine;

[CreateAssetMenu(fileName = "LvlUpCard", menuName = "Data/LvlUpCard")]
public class LvlUpCard : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite lvlUpPicture;
}
