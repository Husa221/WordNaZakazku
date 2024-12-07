using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLeveLPolice : MonoBehaviour
{
    public static int commisionDone = 0;
    // Update is called once per frame
    void Update()
    {
        if(StaticManager.profilesLiked >= 3)
        {
            commisionDone++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
