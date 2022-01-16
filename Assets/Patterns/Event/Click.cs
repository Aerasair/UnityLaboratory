using UnityEngine;
using UnityEngine.Events;

public class Click : MonoBehaviour
{
    private UnityEvent<string> clickButtonEvent;

    [SerializeField]
    private AchivmentShow AchiveWindow;

    void Start()
    {
        if (clickButtonEvent == null)
            clickButtonEvent = new UnityEvent<string>();

        clickButtonEvent.AddListener(AchiveWindow.AcShow);
    }

    void Update()
    {
        if (Input.anyKeyDown && clickButtonEvent != null)
        {
            clickButtonEvent.Invoke("Нажали на красную кнопку");
        }
    }

    private void LogChat()
    {
        Debug.Log("Clicked " + Time.time.ToString());
    }

}
