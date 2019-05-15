using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textManager : MonoBehaviour
{

    public Text text;
    public Button trust;
    public Button noTrust;

    public Text quest;

    public Text dialogueText1;
    public Text dialogueText2;

    private Queue<string> oraciones;

    public bool op1;
    public bool op2;

    private enum States
    {
        question, trustState, noTrustState
    };

    private States myState;



    // Start is called before the first frame update
    void Start()
    {
        myState = States.question;    
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.question) { question(); }
        else if (myState == States.trustState) {trustState(); }
        else if (myState == States.noTrustState) { noTrustState(); }
    }

    private void OnEnable()
    {
        trust.onClick.AddListener(delegate
        {
            op1 = true;
        });
        noTrust.onClick.AddListener(delegate
        {
            op2 = true;
        });
    }

    void question()
    {
        string sentence = oraciones.Dequeue();
        text.text = "Confiarias otra vez?";



        if (op1 == true)
        {
            myState = States.trustState;
        }
        else if (op2 == true)
        {
            myState = States.noTrustState;
        }
    }

    void trustState()
    {
        string sentence = oraciones.Dequeue();
        text.text = "Decidiste confiar";
    }

    void noTrustState()
    {
        string sentence = oraciones.Dequeue();
        text.text = "Decidiste no confiar";
    }

}
