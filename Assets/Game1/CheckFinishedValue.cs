using UnityEngine;
using UnityEngine.Events;

//Подписка на ивент внешнего скрипта   -  mvSl.valueStop
public class CheckFinishedValue : MonoBehaviour
{
    public int randValue { get; private set; }
    [SerializeField] private MovingSlider mvSl;

    public UnityEvent<int> valueGenerated;

    private void Start()
    {
        GenVal();
    }

    private void GenVal()
    {
        randValue = Random.Range(10, 90);
        valueGenerated.Invoke(randValue);
    }
    private void OnEnable()
    {
        mvSl.valueStop.AddListener(CheckTargetValue);
    }

    private void OnDisable()
    {
        mvSl.valueStop.RemoveListener(CheckTargetValue);
    }

    private void CheckTargetValue(int a)
    {
        if (randValue >= a - 5  && randValue <= a + 5  )
        {
           Debug.Log($"Попал {randValue} / {a} ");
        }
        else
        {
            Debug.Log($"Не попал {randValue} / {a} ");
        }
        GenVal();
    }
}
