using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Animator animator;
    public Animator Ayanimator;


    private Queue<string> sentences;
    public bool talking = false;

    // Update is called once per frame
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue (Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);
        Ayanimator.SetBool("isActive", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        if (talking == false)
        {
            string sentence = sentences.Dequeue();
            StopAllCoroutines();
            Ayanimator.SetBool("startsTalking", true);
            StartCoroutine(TypeSentence(sentence));
            talking = true;
        }
        
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            Ayanimator.SetBool("isTalking", true);
            dialogueText.text += letter;
            yield return null;
            Ayanimator.SetBool("isTalking", false);

        }
        Ayanimator.SetBool("startsTalking", false);
        talking = false;
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        Ayanimator.SetBool("isActive", false);
    }
}
