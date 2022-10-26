using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class DetectOnHit : ActionNode
{
    private BoxCollider2D col = null;
    protected override void OnStart() {
        col = context.gameObject.GetComponent<BoxCollider2D>();
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        if(col==null){
            return State.Failure;
        }
        return State.Success;
    }
}
