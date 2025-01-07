using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class StateMachine<EState> : MonoBehaviour where EState : Enum
{
    protected Dictionary<EState, BaseState<EState>> States = new Dictionary<EState, BaseState<EState>>();

    protected BaseState<EState> CurrentState;

    protected bool IsTransitioningState = false;

    protected void Start() {
        CurrentState.EnterState();
    }

    protected void Update() {
        //For now, the states will determine what state they go to next
        //in the future, it should send information to the SM and then the SM will decide
        EState nextStateKey = CurrentState.GetNextState();

        //To make sure we aren't transitioning states
        if (!IsTransitioningState)
        {
            if (nextStateKey.Equals(CurrentState.StateKey))
            {
                CurrentState.UpdateState();
            }
            else
            {
                TransitionToState(nextStateKey);
            }
        }
    }

    protected void TransitionToState(EState stateKey)
    {
        IsTransitioningState = true;
        CurrentState.ExitState();
        CurrentState = States[stateKey];
        CurrentState.EnterState();
        IsTransitioningState = false;
    }

    protected void OnTriggerEnter(Collider other) {
        CurrentState.OnTriggerEnter(other);
    }

    protected void OnTriggerStay(Collider other) {
        CurrentState.OnTriggerStay(other);
    }

    protected void OnTriggerExit(Collider other) {
        CurrentState.OnTriggerExit(other);
    }
}
