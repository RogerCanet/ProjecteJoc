using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAtack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {   
        if(hit.tag == "Player")
        Destroy(hit.gameObject);
    }

}
