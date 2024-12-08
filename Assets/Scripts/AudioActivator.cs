using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioActivator : MonoBehaviour
{
    [SerializeField] AudioMixerSnapshot silent, normal;
    // Start is called before the first frame update
    void Start()
    {
        normal.TransitionTo(1);
    }

}
