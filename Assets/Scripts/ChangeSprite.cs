using Assets.Scripts.SO;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{

    private void OnEnable()
    {
        GetComponent<OpenerBoxes>().Opened +=  Opened; 
    }

    private void OnDisable()
    {
        GetComponent<OpenerBoxes>().Opened -= Opened;
    }

    private void Opened(object item)
    {
        GetComponent<SpriteRenderer>().sprite = (item as Item).Sprite;
    }

}
