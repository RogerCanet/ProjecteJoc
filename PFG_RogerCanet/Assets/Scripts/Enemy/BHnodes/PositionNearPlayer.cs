using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class PositionNearPlayer : ActionNode
{   
    [SerializeField]float offset = 0f;
    private GameObject player = null;
    protected override void OnStart() {
        if (player == null)
        player = GameObject.FindGameObjectWithTag("Player");
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        Vector3 playerPosition = player.transform.position;
        blackboard.moveToPosition.x = playerPosition.x + Random.Range(offset, -offset);
        blackboard.moveToPosition.y = playerPosition.y + Random.Range(offset, -offset);
        return State.Success;
    }
}
