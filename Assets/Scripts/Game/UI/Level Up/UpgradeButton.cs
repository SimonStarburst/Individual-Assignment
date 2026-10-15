using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public Image icon;
    public TMP_Text nameText;
    public TMP_Text descriptionText;


    public void Set(LvlUpCard lvlData)
    {
        icon.sprite = lvlData.lvlUpPicture;
        nameText.text = lvlData.name;
        descriptionText.text = lvlData.description;
    }
}
