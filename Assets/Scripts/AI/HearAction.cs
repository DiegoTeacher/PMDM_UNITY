using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearAction : Action
{
    public float radius = 10f;

    public override bool Check(GameObject owner)
    {
        Collider[] hits = Physics.OverlapSphere(owner.transform.position,
            radius);

        foreach (Collider hit in hits)
        {
            if(hit.GetComponent<PlayerMovement>())
            {
                // estoy escuchando al jugador
                return true;
            }
        }

        return false;
    }
}
