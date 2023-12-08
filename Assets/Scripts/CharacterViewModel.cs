using DefaultNamespace;


public class CharacterViewModel
{
    private CharacterView _characterView;
    public CharacterViewModel(CharacterView view, Character character)
    {
        _characterView = view;
        view.SetupView(character.icon, character.characterName);
    }
}
