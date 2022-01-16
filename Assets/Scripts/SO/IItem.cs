using System;
using UnityEngine;

namespace Assets.Scripts.SO
{
    public interface IItem
    {
         string Identifier { get;  }

         Sprite Sprite { get;  }
    }
}
