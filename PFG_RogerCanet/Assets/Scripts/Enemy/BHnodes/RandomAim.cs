using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class RandomAim : ActionNode
{
    protected override void OnStart() {
        
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        context.transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(0f,359f));
        return State.Success;
    }
}
