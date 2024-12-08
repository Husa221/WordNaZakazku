using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticReset : MonoBehaviour
{
    private void Awake()
    {
        StaticManager.profilesLiked = 0;
        StaticManager.firstChoice = "";
        StaticManager.secondChoice = "";
        StaticManager.lastChoice = "";
    }
}
