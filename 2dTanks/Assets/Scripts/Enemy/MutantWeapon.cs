using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutantWeapon : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;
    private Camera cam;
    private GameObject player = null;

    private float timer = 0f;
    [SerializeField] private float waitingTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        if (player == null)
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Aim at player
        Vector3 playerPosition = player.transform.position;


        Vector3 screenPoint = transform.position;
        
        Vector2 offset = new Vector2(playerPosition.x - screenPoint.x, playerPosition.y -screenPoint.y);

        float angle = Mathf.Atan2(offset.y,offset.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, angle -90);
    
        
        timer += Time.deltaTime;
        if(timer > waitingTime){
            Instantiate(bullet,firePoint.position, transform.rotation);
            timer = 0;
        }
    }
}
