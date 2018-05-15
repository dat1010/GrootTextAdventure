using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    public Text text;
    private enum GameStates {start, sState, mState };
    private GameStates myState;

	// Use this for initialization
	void Start ()
    {
        myState = GameStates.start;
	}
	
	// Update is called once per frame
	void Update ()
    {
        print(myState);
        if (myState == GameStates.start)
        {
            SetStoryText(GetStartStory());
            StartFirst();
        }else if (myState == GameStates.sState)
        {
            SetStoryText(GetsStateText());
            ReturnState();
        }else if (myState == GameStates.mState)
        {
            SetStoryText(GetmStateText());
            ReturnState();
        }
	}

        void StartFirst()
    {
        if (Input.GetKey(KeyCode.S))
        {
            myState = GameStates.sState;
        }
        if (Input.GetKey(KeyCode.M))
        {
            myState = GameStates.mState;
        }
    }

    void ReturnState()
    {
        if (Input.GetKey(KeyCode.R))
        {
            myState = GameStates.start;
        }
    }

    string GetsStateText()
    {
      return  "I... am, Groot \n\n" +
                   "Press R to return to i am Groot";
    }

    void mState()
    {
        if (Input.GetKey(KeyCode.R))
        {
            myState = GameStates.start;
        }
    }

    string GetmStateText()
    {
        return "" +
              "Press R to return to i am Groot"; 
 
    }

    string GetStartStory()
    {
        return "I am groot i am groot I am groot i am groot I am groot i am groot " +
                   "I am groot i am groot I am groot i am groot I am groot i am groot \n\n" +
                   "Press S to i am Groot, M for I AM GROOT!!";
    }


    void SetStoryText(string story)
    {
        text.text = story;
    }

    void MoveToNextState()
    {

    }



}
