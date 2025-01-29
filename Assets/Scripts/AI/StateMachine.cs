using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public State initialState;
    private State _currentState;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = initialState; // punto entrada de la maquina de estados
    }

    // Update is called once per frame
    void Update()
    {
        State nState = _currentState.Run(gameObject);

        if(nState != _currentState)
        {
            // significa que la accion se ha cumplido y debemos
            // cambiar de estado
            _currentState = nState;
        }
    }
}
