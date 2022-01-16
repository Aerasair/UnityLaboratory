using UnityEngine;
using UnityEngine.Events;

//Пример подписки на ивент из класса инизилиазирующего ивент
public class UserInput : MonoBehaviour
{
    private UnityEvent buttonPressed;

    [SerializeField]
    private MovingSlider movSl;

    void Start()
    {
        if (buttonPressed == null)
            buttonPressed = new UnityEvent();

         buttonPressed.AddListener(movSl.behaviorTurnOnOff);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && buttonPressed != null)
        {
            buttonPressed.Invoke();
        }
    }
}
