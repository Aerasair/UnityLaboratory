using Assets.Scripts.SO;
using System;
using UnityEngine;

public class OpenerBoxes : MonoBehaviour
{
    private Box Box;
    public event Action<IItem> Opened = default;

    private void Start()
    {
        this.Box = GetComponent<Box>();
        
    }

    public OpenerBoxes()
    {
      
    }

    LootFactory lootFactory;

    private void Open()
    {
        lootFactory = new LootFactory();
        var item = lootFactory.CreateItem();
         Opened(item);
    }

    private void OnEnable()
    {
        GetComponent<InputPlayer>().LMBClicked += Open;
    }


    private void OnDisable()
    {
        GetComponent<InputPlayer>().LMBClicked -= Open;
    }

}