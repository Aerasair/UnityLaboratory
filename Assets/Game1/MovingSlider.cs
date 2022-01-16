using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

//Пример ивента без инициализации подписчика(см класс CheckFinishedValue)
public class MovingSlider : MonoBehaviour
{
    private int _value = 0;
    private Slider _slider;
    private bool _flagLeftRight = true;

    public UnityEvent<int> valueStop;


    private void Start()
    {
        _value = 0;
        sliderMoving = false;
        _slider = gameObject.GetComponent<Slider>();
    }

    private void Update()
    {
        if (sliderMoving)
            BehaviorSlider();
    }

    private bool sliderMoving;


    public void behaviorTurnOnOff()
    {
        sliderMoving = !sliderMoving;

        if (sliderMoving == false) valueStop.Invoke(_value);
    }


    private void BehaviorSlider()
    {
        if (_flagLeftRight)
            _value += Random.Range(1, 3);
        else
            _value -= Random.Range(1, 3);

        if (_value >= 100)
            _flagLeftRight = false;
        if (_value <= 0)
            _flagLeftRight = true;

        _slider.value = _value;
    }

}
