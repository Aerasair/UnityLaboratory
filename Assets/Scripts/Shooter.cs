using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<InputPlayer>().LMBClicked += OnFired;
    }


    private void OnDisable()
    {
        GetComponent<InputPlayer>().LMBClicked -= OnFired;
    }


    private void OnFired()
    {
        Debug.Log("shoting now" + DateTime.Now.ToString()) ;
    }
}
