using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RightButtonClick : MonoBehaviour
{
    public AudioClip trashSound;
    public AudioClip loveSound;
    public AudioSource audioSource;

    [SerializeField] GameObject[] profileNumber;

    public void ProfileLiked()
    {
        StaticManager.profilesLiked++;

        for(int i = 0; i < profileNumber.Length; i++)
        {
            if (profileNumber[i] != null)
            {
                if (profileNumber[i].activeSelf)
                {
                    if(StaticManager.firstChoice == 100)
                    {
                        StaticManager.firstChoice = i;
                    }else if(StaticManager.secondChoice == 100) 
                    { 
                        StaticManager.secondChoice = i;
                    }else if(StaticManager.lastChoice == 100)
                    {
                        StaticManager.lastChoice = i;
                    }
                }
            }
        }

        Debug.Log("ProfilesLiked: " + StaticManager.profilesLiked);
        Debug.Log("Firstchoice:" + StaticManager.firstChoice);
        Debug.Log("Secondchoice: " + StaticManager.secondChoice);
        Debug.Log("Lasttchoice: " + StaticManager.lastChoice);
    }

    public void trash() 
    {
        Debug.Log("trash");
        audioSource.PlayOneShot(trashSound, 0.7F);
        NextProfile();
    }

    public void love()
    {
        Debug.Log("love");
        audioSource.PlayOneShot(loveSound, 0.7F);
    }

    public void NextProfile()
    {
        int currentprofile = 100;
        Debug.Log("CurrentProfilechoice: " + currentprofile);
        for (int i = 0; i < profileNumber.Length; i++)
        {
            if (profileNumber[i] != null)
            {
                if (profileNumber[i].activeSelf)
                {
                    currentprofile = i + 1;
                    profileNumber[i].SetActive(false);

                }
            }
                
        }
        if(currentprofile >= profileNumber.Length)
        {
            currentprofile = 0;
        }
        while(currentprofile == StaticManager.firstChoice || currentprofile == StaticManager.secondChoice || currentprofile == StaticManager.lastChoice)
        {
            currentprofile++;
            if (currentprofile >= profileNumber.Length)
            {
                currentprofile = 0;
            }
        }

        
        profileNumber[currentprofile].SetActive(true);
        Debug.Log("CurrentProfilechoice2: " + currentprofile);
        Debug.Log("-----------------------------------------");



    }
}
