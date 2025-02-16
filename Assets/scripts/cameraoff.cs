using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffCamera: MonoBehaviour
{
    public GameObject Camera_1;
    public GameObject Camera_2;

    public void OfffCamera()
    {
        Cam_1();
    }
    void Cam_1()
    {
        Camera_1.SetActive(true);
        Camera_2.SetActive(false);
    }
}