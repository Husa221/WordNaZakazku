using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSound : MonoBehaviour
{
    [SerializeField] AudioSource anim;
    [SerializeField] float timer = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StopSound");
    }

  IEnumerator StopSound()
    {
        yield return new WaitForSeconds(timer);
        anim.Stop();

    }
}
