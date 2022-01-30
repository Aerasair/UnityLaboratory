using UnityEngine;

public class Witch : MonoBehaviour
{

    [SerializeField] GameObject _skill;
    [SerializeField] Transform _shootPoint;
    private float speed = 10f;

    public void Shoot(Quaternion quaternion, float lookAngle)
    {
        _shootPoint.rotation = quaternion;
        GameObject bulletclone = Instantiate(_skill);
        bulletclone.transform.position = _shootPoint.position;
        bulletclone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);
        bulletclone.GetComponent<Rigidbody2D>().velocity = -_shootPoint.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Mob")
        {
            Time.timeScale = 0f;
        }
    }
}
