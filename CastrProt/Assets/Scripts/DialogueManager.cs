using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    private Queue<string> oraciones;

    // Start is called before the first frame update
    void Start()
    {
        oraciones = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.nombre;
        oraciones.Clear();

        foreach(string sentence in dialogue.oraciones)
        {
            oraciones.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (oraciones.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = oraciones.Dequeue();
        dialogueText.text = sentence;
    }

    public void EndDialogue()
    {
        Debug.Log("End of COnversation.");
    }
}
