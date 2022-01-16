using UnityEngine;

public class PlaceImage : MonoBehaviour
{
    [SerializeField] private CheckFinishedValue chkF;

    private void OnEnable()
    {
        chkF.valueGenerated.AddListener(PutImage);
    }
    private void OnDisable()
    {
        chkF.valueGenerated.RemoveListener(PutImage);
    }

    [SerializeField] private GameObject targetImage;
    public void PutImage(int randValue)
    {
        targetImage.transform.localPosition = new Vector2((444 / 100) * randValue - 209, 0f);
    }
}
