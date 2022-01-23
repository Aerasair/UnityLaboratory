using UnityEngine;

public class MenuNavigator : MonoBehaviour
{
    [SerializeField] private GameObject[] _menulist;


    public void SelectThisTypeFace(int i)
    {
        TurnOfAll();
        _menulist[i].SetActive(true);
    }

    private void TurnOfAll()
    {
        foreach(GameObject item in _menulist)
        {
            item.SetActive(false);
        }
    }
}
