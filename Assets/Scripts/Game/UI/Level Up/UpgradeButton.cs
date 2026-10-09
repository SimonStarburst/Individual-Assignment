using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] Image icon;

    public void Set(LvlUpCard lvlData)
    {
        icon.sprite = lvlData.lvlUpPicture;
    }
}
