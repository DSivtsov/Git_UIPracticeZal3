using System;
using System.Collections.Generic;
using Object = UnityEngine.Object;

namespace DefaultNamespace
{
    public class CharacterGridPresenter : IDisposable
    {
        public event Action OnGridItemSelected;
        
        private readonly CharacterGridView _characterGridView;
        private readonly CharacterConfigCollection _characterConfigCollection;

        private List<CharacterPresenter> _characterPresenters = new List<CharacterPresenter>();
        
        public CharacterGridPresenter(CharacterGridView characterGridView, CharacterConfigCollection characterConfigCollection)
        {
            _characterGridView = characterGridView;
            _characterConfigCollection = characterConfigCollection;
            
            Initialize();
        }
        
        private void Initialize()
        {
            foreach (var character in _characterConfigCollection.GetAll())
            {
                var newView = Object.Instantiate(_characterGridView.CharacterView);
                var characterPresenter = new CharacterPresenter(newView, character);
                _characterPresenters.Add(characterPresenter);
                characterPresenter.OnViewSelected += OnViewSelected;
            }
        }

        void IDisposable.Dispose()
        {
            foreach (var presenter in _characterPresenters)
            {
                presenter.OnViewSelected -= OnViewSelected;
            }
        }
        
        private void OnViewSelected()
        {
            OnGridItemSelected?.Invoke();
        }
    }
}