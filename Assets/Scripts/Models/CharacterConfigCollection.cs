using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class CharacterConfigCollection : ScriptableObject
    {
        [SerializeField]
        private List<CharacterSO> characters;

        public IReadOnlyList<CharacterSO> GetAll() => characters;
    }
}