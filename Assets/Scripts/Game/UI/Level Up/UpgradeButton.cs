using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] Image icon;
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text descriptionText;


    public void Set(LvlUpCard lvlData)
    {
        icon.sprite = lvlData.lvlUpPicture;
        nameText.text = lvlData.name;
        descriptionText.text = lvlData.description;
    }
}
