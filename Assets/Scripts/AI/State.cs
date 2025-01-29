using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class State
{
    public State nextState;
    public Action action;

    private bool CheckAction(GameObject owner)
    {
        return action.Check(owner) == action.value; // te devuelve si la accion se ha cumplido  
    }

    public virtual State Run(GameObject owner)
    {
        if(CheckAction(owner))
        {
            return nextState;
        }

        return this;
    }
}
