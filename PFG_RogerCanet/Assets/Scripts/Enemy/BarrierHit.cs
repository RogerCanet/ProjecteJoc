using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierHit : MonoBehaviour
{
    private BoxCollider2D col = null;
    // Start is called before the first frame update
    void Start()
    {
        col = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {   if(hit.tag == "PlayerBullet"){
            Destroy(col);
        }
    }
    
}
