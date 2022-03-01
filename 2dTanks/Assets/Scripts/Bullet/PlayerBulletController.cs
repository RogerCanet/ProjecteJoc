using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RB.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {   if(hit.tag != "Player"){
            if(hit.tag == "Enemy"){
                Destroy(hit.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
