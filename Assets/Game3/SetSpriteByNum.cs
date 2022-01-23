using UnityEngine;
using UnityEngine.UI;
using Assets.Game3;

public class SetSpriteByNum : MonoBehaviour
{

    [SerializeField] private int _idObject;
    [SerializeField] private EnumFacesElements _enum;

    private FaceElement _faceElement;

    private void Awake()
    {
        string soPath = $"SOFaces/{_enum.ToString().ToLower()}{_idObject}";
        _faceElement = Resources.Load<FaceElement>(soPath);
        GetComponent<Image>().sprite = _faceElement.Sprite;
    }

 
}
