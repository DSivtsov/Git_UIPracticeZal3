using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(menuName = "SO", fileName = "New character")]
    public class CharacterSO : ScriptableObject
    {
        public Sprite icon;
        public string characterName;
        public Sprite previewImage;
    }
}