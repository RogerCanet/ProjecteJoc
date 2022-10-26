using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class PositionNear : ActionNode
{
    [SerializeField]float maxMovement = 0f;
    protected override void OnStart() {
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        Vector3 myPosition = context.transform.position;
        blackboard.moveToPosition.x = myPosition.x + Random.Range(maxMovement, -maxMovement);
        blackboard.moveToPosition.y = myPosition.y + Random.Range(maxMovement, -maxMovement);
        return State.Success;
        
    }
}
