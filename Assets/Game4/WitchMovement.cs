using UnityEngine;

public class WitchMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;

    public void Move(Vector2 direction)
    {
        _rigidbody2D.velocity = direction.normalized * _speed;



    }
}
