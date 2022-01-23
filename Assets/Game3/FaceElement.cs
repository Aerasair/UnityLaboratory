using UnityEngine;
using Assets.Game3;

[CreateAssetMenu(fileName = "FaceEl_", menuName = "New Face element", order = 10)]
public class FaceElement : ScriptableObject
{
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite => _sprite; 
    
    [SerializeField] private int _id;
    public int ID => _id;

    [SerializeField] private EnumFacesElements _type;
    public EnumFacesElements Type => _type;


}
