using UnityEngine;
using System.Linq;
using Assets.Game3;

public class Face : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteHead;
    [SerializeField] private SpriteRenderer _spriteEyes;
    [SerializeField] private SpriteRenderer _spriteEyeBrows;
    [SerializeField] private SpriteRenderer _spriteMouth;

    private FaceElement[] _faceElements;

    private void Start()
    {
        _faceElements  = Resources.LoadAll<FaceElement>("SOFaces");
    }

    public void SetHead(int element_id)
    {
        _spriteHead.sprite =  _faceElements.Where(r=>r.ID == element_id && r.Type == EnumFacesElements.head).FirstOrDefault().Sprite;
    }

    public void SetEyes(int element_id)
    {
        _spriteEyes.sprite = _faceElements.Where(r => r.ID == element_id && r.Type == EnumFacesElements.eyes).FirstOrDefault().Sprite;
    }

    public void SetBrows(int element_id)
    {
        _spriteEyeBrows.sprite = _faceElements.Where(r => r.ID == element_id && r.Type == EnumFacesElements.brows).FirstOrDefault().Sprite;
    }

    public void SetMouth(int element_id)
    {
        _spriteMouth.sprite = _faceElements.Where(r => r.ID == element_id && r.Type == EnumFacesElements.mouth).FirstOrDefault().Sprite;
    }

    public void GenRandomFace()
    {
        _spriteHead.sprite = _faceElements.Where(r => r.Type == EnumFacesElements.head).ToList()[Random.Range(0,8)].Sprite;
        _spriteEyes.sprite = _faceElements.Where(r => r.Type == EnumFacesElements.eyes).ToList()[Random.Range(0,8)].Sprite;
        _spriteMouth.sprite = _faceElements.Where(r => r.Type == EnumFacesElements.mouth).ToList()[Random.Range(0,8)].Sprite;
    }
}




