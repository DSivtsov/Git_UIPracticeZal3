using System;
using DefaultNamespace;


public class CharacterPresenter
{
    public event Action OnViewSelected;
    
    private CharacterView _characterView;

    public CharacterPresenter(CharacterView view, CharacterSO characterSo)
    {
        _characterView = view;
        view.SetupView(characterSo.icon, characterSo.characterName);
        view.OnSelected += OnSelected;
    }

    private void OnSelected()
    {
        OnViewSelected?.Invoke();
    }
}
