using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.EditorUtilities;
using Unity.VisualScripting;

public class LevelUpButton : MonoBehaviour
{
    [SerializeField] private LevelUpRandomizer levelUpRandomizer;

    public LvlUpCard lvlUpCard;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image icon;

public void Set(LvlUpCard lvlUpCard)
    {
        icon.sprite = lvlUpCard.lvlUpPicture;
    }
}
