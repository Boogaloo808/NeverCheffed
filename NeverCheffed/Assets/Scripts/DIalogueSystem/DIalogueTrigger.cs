using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DIalogueTrigger : MonoBehaviour

{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindFirstObjectByType<DialogueManager>().StartDialogue(dialogue);
    }
        
}
