using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reEnableCanvas : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reEnable()
    {
        canvas.SetActive(true);
    }
}
