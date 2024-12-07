using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApp : MonoBehaviour
{
    [SerializeField] AudioSource buttonSound;
    public void AppQut()
    {
        buttonSound.Play();
        Application.Quit();
    }
}
