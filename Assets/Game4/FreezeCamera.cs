using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeCamera : MonoBehaviour
{


    void Update()
    {
       gameObject.transform.position = new Vector3(gameObject.transform.position.x,  -1.4f, -10);
    }
}
