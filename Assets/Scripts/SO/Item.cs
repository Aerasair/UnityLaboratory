using System;
using UnityEngine;

namespace Assets.Scripts.SO
{
    [Serializable]
    public class Item : IItem
    {
        [SerializeField]
        private string _identifier;

        [SerializeField]
        private Sprite __sprite;

        public string Identifier { get => _identifier;  }
        public Sprite Sprite { get => __sprite;  }
    }
}
