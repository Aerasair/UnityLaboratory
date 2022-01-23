using Assets.Game2;
using UnityEngine;

public class Mage : Entity
{
    private void Update()
    {
        if (_moveGame.PlayerMove == false) { 
            Attack();
            _moveGame.PlayerMove = true;
        }
    }

    public override void Attack()
    {
        _vectorAttack = (EnumDirections)Random.Range(1,4);
        _vectorShield = (EnumDirections)Random.Range(1,4);

       bool resultAttack =  _target.TakeDamage(_vectorAttack);

        ui.SetHPEnemy(_currentHealth);
    }

}
