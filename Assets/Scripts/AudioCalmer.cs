using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioCalmer : MonoBehaviour
{
    [SerializeField] AudioMixerSnapshot silent, normal;
    // Start is called before the first frame update
    void Start()
    {
        silent.TransitionTo(1);
    }

   
}
