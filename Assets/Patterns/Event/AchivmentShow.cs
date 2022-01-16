using UnityEngine;
using UnityEngine.UI;

public class AchivmentShow : MonoBehaviour
{
    public void AcShow(string activementName)
    {
        GetComponent<DoTFade>().FadeIn(1f);
        gameObject.transform.Find("Text").GetComponent<Text>().text = activementName;
    }
}
