using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticReset : MonoBehaviour
{
    private void Awake()
    {
        StaticManager.profilesLiked = 0;
        StaticManager.firstChoice = 100;
        StaticManager.secondChoice = 100;
        StaticManager.lastChoice = 100;
    }
}
