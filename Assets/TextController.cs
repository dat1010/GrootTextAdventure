using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    public Text text;
    private enum GameStates {start, sState, mState, gState };
    private GameStates myState;

	// Use this for initialization
	void Start () {
        myState = GameStates.start;
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if (myState == GameStates.start)
        {
            //SetStoryText(GetStartStory());
            StartFirst();
        }else if (myState == GameStates.sState)
        {
            sState();
        }else if (myState == GameStates.mState)
        {
        }
	}

    void StartFirst()
    {
        text.text = "I am groot i am groot I am groot i am groot I am groot i am groot " +
                   "I am groot i am groot I am groot i am groot I am groot i am groot \n\n" +
                   "Press S to i am Groot, M for I AM Groot, G I AM GROOT!!";
        if (Input.GetKey(KeyCode.S))
        {
            myState = GameStates.sState;
        }
    }

    //void StartFirst()
    //{
    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        myState = GameStates.sState;
    //    }
    //}

    void sState()
    {
        text.text = "I... am, Groot \n\n" +
                   "Press R to return to i am Groot";
        if (Input.GetKey(KeyCode.R))
        {
            myState = GameStates.start;
        }
    }

    void mState()
    {

    }











    string GetStartStory()
    {
        return "I am groot i am groot I am groot i am groot I am groot i am groot " +
                   "I am groot i am groot I am groot i am groot I am groot i am groot \n\n" +
                   "Press S to i am Groot, M for I AM Groot, G I AM GROOT!!";
    }


    void SetStoryText(string story)
    {
        text.text = story;
    }

    void MoveToNextState()
    {

    }



}
