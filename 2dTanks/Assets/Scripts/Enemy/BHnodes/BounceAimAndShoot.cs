using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class BounceAimAndShoot : ActionNode
{
    private GameObject player = null;
    protected override void OnStart() {
        if (player == null)
        player = GameObject.FindGameObjectWithTag("Player");
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        //Aim at player
        Vector3 playerPosition = player.transform.position;

        Vector3 myPosition = context.transform.position;
        
        Vector2 offset = new Vector2(playerPosition.x - myPosition.x, playerPosition.y -myPosition.y);

        float angle = Mathf.Atan2(offset.y,offset.x) * Mathf.Rad2Deg;

        context.transform.rotation = Quaternion.Euler(0f, 0f, angle -90);

        RaycastHit2D hit = Physics2D.Raycast(context.transform.position, offset);
        
        if(hit.collider.CompareTag("Player"))
            context.gameObject.GetComponent<Weapon>().shoot();
        else{
            context.transform.rotation = Quaternion.Euler(0f, 0f, angle - Random.Range(0,180));
            context.gameObject.GetComponent<Weapon>().shoot();
        }
        return State.Success;
        
    }
}
