using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CubeFollow : MonoBehaviour
{

    private Vector3 initialPos;
    private Vector3 pos2;
    private bool teleported = false;

    void Start()
    {
        transform.position = transform.localPosition;
        initialPos = transform.localPosition;
        pos2 = initialPos + (new Vector3(3f, 0.0f, 0.0f));
    }

    public void Teleport()
    {
        if (teleported)
        {
            transform.position = initialPos;
            teleported = false;
        }
        else
        {
            transform.position = pos2;
            teleported = true;
        }
    }

}
