using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class CharacterRepository : ScriptableObject
    {
        [SerializeField]
        private List<Character> characters;

        public IReadOnlyList<Character> GetAll() => characters;
        
        
    }
}