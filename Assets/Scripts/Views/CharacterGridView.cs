using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    // список персонажей
    public class CharacterGridView : MonoBehaviour
    {
        [SerializeField] private CharacterView characterViewPrefab;
        [SerializeField] private Transform root;
        public CharacterView CharacterView => characterViewPrefab;
    }
}