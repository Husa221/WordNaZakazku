using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reEnableCanvas : MonoBehaviour
{
    public GameObject canvas;

    public void reEnable()
    {
        canvas.SetActive(true);
    }
}
