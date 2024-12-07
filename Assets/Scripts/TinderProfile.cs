using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TinderProfile", fileName = "New Tinder Profile")]
public class TinderProfile : ScriptableObject
{
    public Sprite profilePicture;
    public string profileName;
    public string aboutMe;
}
