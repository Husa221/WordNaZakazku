using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public GameObject target;
    [SerializeField] float speedrot;
    private void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, speedrot * Time.deltaTime);
    }
}
