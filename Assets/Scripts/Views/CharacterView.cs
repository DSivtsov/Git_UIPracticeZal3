using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterView : MonoBehaviour
{
    public event Action OnSelected;
    
    [SerializeField] private Image characterIcon;
    [SerializeField] private TextMeshProUGUI characterText;

    public void SetupView(Sprite icon, string text)
    {
        characterIcon.sprite = icon;
        characterText.SetText(text);
    }
}
