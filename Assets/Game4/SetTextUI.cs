using UnityEngine;
using UnityEngine.UI;

public class SetTextUI : MonoBehaviour
{
    [SerializeField] private Text _coinText;

    private int _coins = 0;

    public void SetCoinText(int i)
    {
        _coins += i;
        _coinText.text = $"Coins: {_coins.ToString()}"; 
    }
}
