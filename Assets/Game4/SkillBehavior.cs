using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SkillBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Mob")
        {
            collision.gameObject.GetComponent<Mob>().TakeDamage(10000);
            Destroy(gameObject);
        }
        if(collision.transform.tag == "Wall")
        {
            Destroy(gameObject);
        }

    }
}
