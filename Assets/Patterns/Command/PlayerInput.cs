using Assets.Patterns.Command;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Invoker invoker;
    private void Start()
    {
        invoker = new Invoker();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) invoker.RunCom(new GoUp(gameObject));
        if(Input.GetKeyDown(KeyCode.S)) invoker.RunCom(new GoDown(gameObject));
        if(Input.GetKeyDown(KeyCode.Space)) invoker.PressUndo();
    }

}
