using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfileCreator : MonoBehaviour
{
    [SerializeField] TinderProfile tinderProfile;
    [SerializeField] Image artworkProfile;
    [SerializeField] TMP_Text nameProfile;
    [SerializeField] TMP_Text descriptionProfile;

    void Start()
    {
        artworkProfile.sprite = tinderProfile.profilePicture;
        nameProfile.text = tinderProfile.profileName;
        descriptionProfile.text = tinderProfile.aboutMe;




    }


}
