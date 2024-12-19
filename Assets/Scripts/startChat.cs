using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class startChat : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    public void onClick()
    {
        dialogueRunner.StartDialogue(gameObject.transform.parent.name);
        gameObject.SetActive(false);
        GameObject canvas = GameObject.Find("CanvasOur");
        canvas.SetActive(false);
    }
}
