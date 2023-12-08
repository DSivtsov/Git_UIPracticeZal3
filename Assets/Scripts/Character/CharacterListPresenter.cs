using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    // список персонажей
    public class CharacterListPresenter : MonoBehaviour
    {
        [SerializeField] private CharacterView characterViewPrefab;
        [SerializeField] private Transform root;

        private List<CharacterView> _characterViews;
        
        public void Initialize(CharacterRepository characterRepository)
        {
            foreach (var character in characterRepository.GetAll())
            {
                var newView = Instantiate(characterViewPrefab, root);
                newView.SetupView(character.icon, character.characterName);
                var newViewModel = new CharacterViewModel(newView, character);
                _characterViews.Add(newView);
            }
        }
    }
}