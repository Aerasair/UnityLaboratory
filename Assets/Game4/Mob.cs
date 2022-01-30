using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Mob : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] protected GameObject _chestPref;
    [SerializeField] protected float _speed = 5f;
    [SerializeField] protected float _rotationSpeed = 10f;

    protected Rigidbody2D _rigidbody2D;
    private int _currentHealth;

    private bool IsAlive = true;


    protected virtual void Start()
    {
        _currentHealth = _maxHealth;
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        if(_currentHealth <= 0 )
        {
            SpawnDrop();
            Destroy(gameObject);
        }
    }

    protected abstract void Move();

    protected virtual void SpawnDrop()
    {
        if (IsAlive)
        {
            GameObject chest = Instantiate(_chestPref);
            chest.transform.position = transform.position;
            IsAlive = false;
        }
    }


}
