using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //Aim
        Vector3 mouse = Input.mousePosition;

        Vector3 screenPoint = cam.WorldToScreenPoint(transform.localPosition);

        Vector2 offset = new Vector2(mouse.x - screenPoint.x, mouse.y -screenPoint.y);

        float angle = Mathf.Atan2(offset.y,offset.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, angle -90);
    
        if(Input.GetMouseButtonDown(0) && !pauseMenu.isPaused){
            Instantiate(bullet,firePoint.position, transform.rotation);
        }
    }
}
