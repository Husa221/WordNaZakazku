using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    [SerializeField] AudioSource buttonSound;

    public void InvokeNextLevel()
    {
        buttonSound.Play();
        Invoke("NextLevel", 0.2f);
    }
    public void NextLevel()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void NextCommision()
    {
        buttonSound.Play();
       
        SceneManager.LoadScene("CommisionScene");
    }
}
