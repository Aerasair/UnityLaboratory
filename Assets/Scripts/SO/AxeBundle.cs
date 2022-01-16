using UnityEngine;

namespace Assets.Scripts.SO
{
    [CreateAssetMenu(fileName = "New AxeData", menuName = "AxeBundleData", order = 10)]
    public class AxeBundle : ScriptableObject 
    {
        [SerializeField]
        private Item[] _axeData;

        public Item[] AxeData => _axeData;

     
    }
}

