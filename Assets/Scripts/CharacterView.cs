using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterView : MonoBehaviour
{
    [SerializeField] private Image characterIcon;
    [SerializeField] private Image characterView;
    [SerializeField] private TextMeshProUGUI characterText;

    public Sprite CharacterView1 => characterView.sprite;
    
    public void SetupView(Sprite icon, Sprite character, string text)
    {
        characterView.sprite = character;
        characterIcon.sprite = icon;
        characterText.SetText(text);
    }
}
