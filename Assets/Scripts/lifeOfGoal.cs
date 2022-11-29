using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class lifeOfGoal : MonoBehaviour
{
     PhotonView view;
    public int hits = 0;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {   
         view = PhotonView.Get(this);
        
    }
    // Update is called once per frame
    void Update()
    {
          if(hits >= 1)
        {
           // Instantiate(explosion, transform.position, Quaternion.identity);           
           
            PhotonNetwork.Destroy(this.gameObject);
            PhotonNetwork.Instantiate(explosion.name,transform.position, transform.rotation); 
        }
    }
             void OnCollisionEnter2D(Collision2D coll)
    {
        // If the Collider2D component is enabled on the collided object
        if (coll.transform.tag == "star")
        {
            hits ++;     
            Debug.Log("oi");
        }   
  
        
         
    }
}
