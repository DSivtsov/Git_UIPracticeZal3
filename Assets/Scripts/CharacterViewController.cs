using UnityEngine;

public class CharacterViewController
{
    private CharacterView _characterView;

    public CharacterViewController(CharacterView view, Sprite character, Sprite icon, string text)
    {
        _characterView = view;
        view.SetupView(character, icon, text);
    }

    public Sprite GetCharacterSprite()
    {
        return _characterView.CharacterView1;
    }
}
