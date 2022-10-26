using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;
    [SerializeField] private int weapon;
    private float timer = 0f;
    [SerializeField] private float waitingTime = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    public void shoot(){
        switch (weapon){
        case 0:
            break;
        case 1:
            if(timer > waitingTime){
                Instantiate(bullet,firePoint.position, transform.rotation);
                timer = 0;
            }
            break;
        case 2:
        if(timer > waitingTime){
            Instantiate(bullet,firePoint.position, transform.rotation);
            Instantiate(bullet,firePoint.position, transform.rotation * Quaternion.Euler(0,0,10));
            Instantiate(bullet,firePoint.position, transform.rotation * Quaternion.Euler(0,0,-10));
            timer = 0;
        }
        break;
        default:
        break;
        }
    }
}
