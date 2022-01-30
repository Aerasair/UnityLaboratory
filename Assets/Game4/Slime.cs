
using UnityEngine;

public class Slime : Mob
{
    private Transform _target;

    protected override void Start()
    {
        base.Start();
        _target = GameObject.FindGameObjectWithTag("Witch").transform;
        Move();
    }

    protected override void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    private void Update()
    {
        Move();
    }
}
