using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceEnemyBulletController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D RB;
    private Vector3 lastVelocity;
    // Start is called before the first frame update
    void Start()
    {
        RB = gameObject.GetComponent<Rigidbody2D>();
        RB.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        lastVelocity = RB.velocity;
    }


    private void OnCollisionEnter2D(Collision2D col){

        if(col.collider.tag == "Player"){
            Destroy(col.collider.gameObject);
            Destroy(gameObject);
        }
        //Destroy(gameObject);
        
    }
}
