using UnityEngine;

namespace Assets.Scripts.SO
{
    [CreateAssetMenu(fileName = "New SwordData", menuName = "SwordBundleData", order = 10)]
    public class SwordBundle : ScriptableObject
    {
        [SerializeField]
        private Item[] _swordData;

        public Item[] SwordData => _swordData;

    }
}

