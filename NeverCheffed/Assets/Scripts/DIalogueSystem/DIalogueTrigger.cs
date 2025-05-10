using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DIalogueTrigger : MonoBehaviour

{
    public Dialogue dialogue;

    public void Start()
    {
        FindFirstObjectByType<DialogueManager>().StartDialogue(dialogue);
    }
        
}
