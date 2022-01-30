using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    [SerializeField] Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetMovingAnimation(float axis)
    {
        _animator.SetFloat("New Float", Mathf.Abs(axis));

        SetFlipByAxis(axis);
    }

    private void SetFlipByAxis(float axis)
    {
        if (axis > 0)
            _spriteRenderer.flipX = false;
        if (axis < 0)
            _spriteRenderer.flipX = true;
    }
}
