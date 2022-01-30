using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WitchInput : MonoBehaviour
{
    [SerializeField] private WitchMovement _movement;
    [SerializeField] private ChangeAnimation _changeAnimation;
    [SerializeField] private Witch _witch;

    private void Update()
    {
        MovingPlayer();
        Shoting();

        CheckResetButton();
    }

    private void CheckResetButton()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1f;
        }
    }

    private void MovingPlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        _movement.Move(new Vector2(horizontal, vertical));

        FlipPlayer(horizontal, vertical);
    }

    private void FlipPlayer(float horizontal, float vertical)
    {
        _changeAnimation.SetMovingAnimation(horizontal + vertical);
    }

    private void Shoting()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            GetVectorShoot();
    }

    private void GetVectorShoot()
    {
        //Get the Screen positions of the object
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        //Get the Screen position of the mouse
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //Get the angle between the points
        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

        var rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));

        _witch.Shoot(rotation, angle);
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

}
