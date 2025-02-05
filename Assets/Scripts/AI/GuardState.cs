using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "GuardState (S)", menuName = "ScriptableObjects/States/GuardState")]
public class GuardState : State
{
    public Vector3 guardPoint;

    public override State Run(GameObject owner)
    {
        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(guardPoint);

        return base.Run(owner);
    }
}
