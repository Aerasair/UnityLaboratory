using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMesh _hpPlayer;
    [SerializeField] private TextMesh _hpEnemy;
    [SerializeField] private TextMesh _resultAttackOnPlayer;
    [SerializeField] private TextMesh _resultAttackOnEnemy;


    public void SetHPPlayer(int hp)
    {
        _hpPlayer.text = $"{hp}";
    }  
    
    public void SetHPEnemy(int hp)
    {
        _hpEnemy.text = $"{hp}";
    }


    public void ResultAttackOnPlayer(string text)
    {
        _resultAttackOnPlayer.text = text;
    }  
    public void ResultAttackOnEnemy(string text)
    {
        _resultAttackOnEnemy.text = text;
    }

}
