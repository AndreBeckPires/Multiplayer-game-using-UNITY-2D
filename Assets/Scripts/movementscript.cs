using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscript : MonoBehaviour
{
    // Start is called before the first frame update
   public float speed = 10.5f; 

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 mousePosition = (Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector2 direction = (mousePosition - transform.position).normalized;


        if (Input.GetKey("w")) 
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s")) 
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d")) 
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a")) 
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
        transform.up = direction;
    }
}
