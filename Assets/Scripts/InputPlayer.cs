using System;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    public bool IsFire { get; private set; }

    public event Action LMBClicked = default;

    private void Update()
    {
        IsFire = Input.GetButtonDown("Fire1");

        if (IsFire && LMBClicked != null)
        {
            LMBClicked();
        }
    }
}
