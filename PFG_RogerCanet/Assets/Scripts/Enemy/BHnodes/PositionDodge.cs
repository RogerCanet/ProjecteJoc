using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class PositionDodge : ActionNode
{
    [SerializeField]float maxMovement = 0f;
    private GameObject player = null;
    protected override void OnStart() {
        if (player == null)
        player = GameObject.FindGameObjectWithTag("Player");
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        Vector3 playerPosition = player.transform.position;
        Vector3 myPosition = context.transform.position;
        Vector3 myNewPosition = player.transform.position;
        do{
            myNewPosition.x = myPosition.x + Random.Range(maxMovement, -maxMovement);
            myNewPosition.y = myPosition.y + Random.Range(maxMovement, -maxMovement);
        }while(myNewPosition - playerPosition == myPosition - playerPosition && myNewPosition != myPosition);
        blackboard.moveToPosition.x = myNewPosition.x + Random.Range(maxMovement, -maxMovement);
        blackboard.moveToPosition.y = myNewPosition.y + Random.Range(maxMovement, -maxMovement);
        return State.Success;
        
    }
}
