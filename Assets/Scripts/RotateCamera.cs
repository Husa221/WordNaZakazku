using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    [SerializeField] float spinningSpeed = 1f;
    void Update()
    {
        transform.Rotate(0,spinningSpeed, 0);
    }
}
