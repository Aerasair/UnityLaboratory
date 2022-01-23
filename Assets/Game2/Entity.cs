using Assets.Game2;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public abstract class Entity : MonoBehaviour
{
    [Header("Общие статы")]
    [Range(0,50)]
    [SerializeField] protected int _maxHealth;
    [SerializeField] protected Entity _target;
    [Header("Вектора")]
    [Tooltip("Вектор атаки")]
    [SerializeField] protected EnumDirections _vectorAttack;
    [Tooltip("Вектор защиты")]
    [SerializeField] protected EnumDirections _vectorShield;


    [SerializeField] protected UI ui;

    [SerializeField] protected Animator _animator;
    [SerializeField] private Sprite _sprite;
    [SerializeField] protected MoveGame _moveGame;
    protected int _currentHealth;

    private void Start()
    {
        ui = GameObject.FindGameObjectWithTag("UI").GetComponent<UI>();
        _currentHealth = _maxHealth;
        GetComponent<SpriteRenderer>().sprite = _sprite;
        _animator = GetComponent<Animator>();
    }

    public bool TakeDamage(EnumDirections dir)
    {
        if (_vectorShield == EnumDirections.none) SetShield(Random.Range(1, 4));
        if (dir != _vectorShield)
        {
            _currentHealth -= 1;

            Debug.Log($"Попал по {gameObject.name} Hp = {_currentHealth} Атака на {dir} Защита на {_vectorShield}");
            _animator.SetBool("Hit", true);
            return true;
        }
        else
        {
            Debug.Log($"Промах по {gameObject.name} Hp = {_currentHealth} Атака на {dir} Защита на {_vectorShield}");
            return false;
        }

        if (_currentHealth <= 0)
        {
            Debug.Log($"{gameObject.name} умер");
            return true;
        }
    }

    public void FinishedHit()
    {
        _animator.SetBool("Hit", false);
    }


    public abstract void Attack();

    public void SetShield(int i)
    {
        _vectorShield = (EnumDirections)i;
    }

    public void SetAttack(int i)
    {
        _vectorAttack = (EnumDirections)i;
    }

}
