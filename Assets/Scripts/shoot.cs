

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject[] starPrefab;
    public Transform firePoint;
    public Vector3 pos;
    public float bulletForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
         if (Input.GetMouseButtonDown(0))
         {
            trigger();
            
         }
           
    }
    void trigger(){
        GameObject bullet = Instantiate(starPrefab[0], pos, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
