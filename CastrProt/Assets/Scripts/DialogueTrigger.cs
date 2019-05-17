using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogo;
    public Scene scene;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogo);
    }

    public void CambiarEscena()
    {
        SceneManager.LoadScene(scene.name);
    }

}
