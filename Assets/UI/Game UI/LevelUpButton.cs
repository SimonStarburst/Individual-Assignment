using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.EditorUtilities;

public class LevelUpButton : MonoBehaviour
{
    public LvlUpCard lvlUpCard;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image artImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nameText.text = lvlUpCard.name;
        descriptionText.text = lvlUpCard.description;
    }

}
