using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCursorVis : MonoBehaviour
{
    public GameObject cam;

    // Update is called once per frame
    void Update()
    {
        if (cam == true)
        {
            Cursor.visible = true;
        }
        if (cam == false)
        {
            Cursor.visible = false;
        }
    }
}
