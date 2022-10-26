using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshAgentFix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        gameObject.GetComponent<Transform>().Rotate(90f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
