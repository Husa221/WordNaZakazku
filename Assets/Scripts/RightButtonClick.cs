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

    void Start()
    {
        // Shuffle scenarios array
        Shuffle(profileNumber);
        profileNumber[0].SetActive(true);
    }


    void Shuffle(GameObject[] a)
    {
        // Loops through array
        for (int i = a.Length - 1; i > 0; i--)
        {
            // Randomize a number between 0 and i (so that the range decreases each time)
            int rnd = Random.Range(0, i);

            // Save the value of the current i, otherwise it'll overright when we swap the values
            GameObject temp = a[i];

            // Swap the new and old values
            a[i] = a[rnd];
            a[rnd] = temp;
        }

        // Print
        for (int i = 0; i < a.Length; i++)
        {
            Debug.Log(a[i]);
        }
    }

    public void ProfileLiked()
    {
        StaticManager.profilesLiked++;

        for(int i = 0; i < profileNumber.Length; i++)
        {
            if (profileNumber[i].activeSelf)
            {
                if(StaticManager.firstChoice == "")
                {
                    StaticManager.firstChoice = profileNumber[i].name;
                }else if(StaticManager.secondChoice == "") 
                { 
                    StaticManager.secondChoice = profileNumber[i].name;
                }else if(StaticManager.lastChoice == "")
                {
                    StaticManager.lastChoice = profileNumber[i].name;
                }
                break;
            }
        }

        Debug.Log("profilesLiked: " + StaticManager.profilesLiked);
        Debug.Log("firstChoice:" + StaticManager.firstChoice);
        Debug.Log("secondChoice: " + StaticManager.secondChoice);
        Debug.Log("lastChoice: " + StaticManager.lastChoice);
    }

    public void trash() 
    {
        Debug.Log("trash() called");
        audioSource.PlayOneShot(trashSound, 1.0F);
        NextProfile();
    }

    public void love()
    {
        Debug.Log("love() called");
        audioSource.PlayOneShot(loveSound, 1.2F);
    }

    public void NextProfile()
    {
        int currentprofile = 0;
        Debug.Log("currentprofile: " + currentprofile);
        for (int i = 0; i < profileNumber.Length; i++)
        {
            if (profileNumber[i].activeSelf)
            {
                currentprofile = i + 1;
                profileNumber[i].SetActive(false);
                Debug.Log($"Instance {profileNumber[i].name} disabled");
                break;
            }
        }
        if (currentprofile >= profileNumber.Length)
        {
            currentprofile = 0;
        }

        while (profileNumber[currentprofile].name == StaticManager.firstChoice || profileNumber[currentprofile].name == StaticManager.secondChoice || profileNumber[currentprofile].name == StaticManager.lastChoice)
        {
            currentprofile++;
            if (currentprofile >= (profileNumber.Length))
            {
                currentprofile = 0;
            }
        }
        
        profileNumber[currentprofile].SetActive(true);
        Debug.Log($"Instance {profileNumber[currentprofile].name} enabled");
        Debug.Log("currentprofile: " + currentprofile);
        Debug.Log("-----------------------------------------");



    }
}
