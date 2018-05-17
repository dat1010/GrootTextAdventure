using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    class StateMachine
    {
        private enum GameStates {start, sState, mState };
        private GameStates myState;

        public StateMachine()
        {
            myState = GameStates.start;
        }

        public void Machine()
        {
            if (myState == GameStates.start)
            {
                //SetStoryText(GetStartStory());
                StartFirst();
            }
            else if (myState == GameStates.sState)
            {
                //SetStoryText(GetsStateText());
                ReturnState();
            }
            else if (myState == GameStates.mState)
            {
                //SetStoryText(GetmStateText());
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


        void mState()
        {
            if (Input.GetKey(KeyCode.R))
            {
                myState = GameStates.start;
            }
        }

        void ReturnState()
        {
            if (Input.GetKey(KeyCode.R))
            {
                myState = GameStates.start;
            }
        }

    }
}
