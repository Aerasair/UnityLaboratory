using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private int _coins;
    [SerializeField] private Sprite _spriteOpened;

     private SetTextUI setTextUI;

    private bool Opened = false;

    private void Start()
    {
        setTextUI = GameObject.FindGameObjectWithTag("setTextUI").GetComponent<SetTextUI>();
        _coins = Random.Range(0, 10);
    }

    private void OpenChest()
    {
        GetComponent<SpriteRenderer>().sprite = _spriteOpened;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Witch")
        {
            if (Opened == false)
            {
                OpenChest();
          
                setTextUI.SetCoinText(_coins);
                Opened = true;
                Destroy(gameObject, 3f);
            }
        }
    }
}
