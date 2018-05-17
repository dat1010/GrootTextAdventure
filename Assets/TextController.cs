using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    public Text text;
    private enum GameStates {start, sState, mState };
    private GameStates myState;

    private Assets.StateMachine stateMachine;
    private Assets.TextGenerator textGen;

	// Use this for initialization
	void Start ()
    {
        stateMachine = new Assets.StateMachine();
        textGen = new Assets.TextGenerator();
	}
	
	// Update is called once per frame
	void Update ()
    {
        print(myState);
        stateMachine.Machine();
	}

   
    void SetStoryText(string story)
    {
        text.text = story;
    }

    void MoveToNextState()
    {

    }



}
