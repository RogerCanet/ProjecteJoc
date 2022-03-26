using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class ZombiePlayerDetection : ActionNode
{    [SerializeField]float circleRad = 0;
    private GameObject player = null;
    protected override void OnStart() {
        if (player == null)
        player = GameObject.FindGameObjectWithTag("Player");
        Debug.DrawLine(context.transform.position,(context.transform.position + new Vector3(circleRad, 0, 0)),Color.white);
        Debug.DrawLine(context.transform.position,(context.transform.position - new Vector3(circleRad, 0, 0)),Color.white);
        Debug.DrawLine(context.transform.position,(context.transform.position + new Vector3(0, circleRad, 0)),Color.white);
        Debug.DrawLine(context.transform.position,(context.transform.position - new Vector3(0, circleRad, 0)),Color.white);
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        Vector3 playerPosition = player.transform.position;
        Vector3 ownPosition = context.transform.position;
        if(Vector3.Distance(playerPosition,ownPosition) < circleRad){
            blackboard.moveToPosition.x = playerPosition.x;
            blackboard.moveToPosition.y = playerPosition.y;
        }
        else{
            blackboard.moveToPosition.x = ownPosition.x;
            blackboard.moveToPosition.y = ownPosition.y;
        }
        return State.Success;
    }
}
