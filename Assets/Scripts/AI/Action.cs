using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action
{
    public bool value;

    public abstract bool Check(GameObject owner);
}
