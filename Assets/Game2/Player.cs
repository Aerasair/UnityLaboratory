using UnityEngine;
using Assets.Game2;

public class Player : Entity
{
    public override void Attack()
    {
        if (_vectorShield == EnumDirections.none && _vectorShield == EnumDirections.none) return;

        if (_moveGame.PlayerMove)
        {
            _target.TakeDamage(_vectorAttack);
            _moveGame.PlayerMove = false;

            ui.SetHPPlayer(_currentHealth);
          //  ui.ResultAttackOnEnemy("попал");
        }
    }

    
}
