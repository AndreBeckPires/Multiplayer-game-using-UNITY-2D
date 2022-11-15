using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovetest : MonoBehaviour
{

     public float speed = 10.5f; 
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<SpriteRenderer>().sprite.name == "whiteninja 1")
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
}
