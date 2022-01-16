using Assets.Scripts.SO;
using System.Collections.Generic;
using UnityEngine;

public class LootFactory : MonoBehaviour
{
    private List<IItem> itemFactory = new List<IItem>();

    private AxeBundle axes;
    private SwordBundle swords;

    public LootFactory()
    {
         axes = (AxeBundle)Resources.Load("SOCollection/AxeData");
         swords = (SwordBundle)Resources.Load("SOCollection/SwordData");
    }

    public IItem CreateItem()
    {
       itemFactory.AddRange(axes.AxeData);

      itemFactory.AddRange(swords.SwordData);

        return itemFactory[Random.RandomRange(0,itemFactory.Count)];
    }
}
