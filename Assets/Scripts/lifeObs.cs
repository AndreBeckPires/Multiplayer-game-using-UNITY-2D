using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class lifeObs : MonoBehaviour
{
     PhotonView view;
     public int hits = 0;
    // Start is called before the first frame update
    void Start()
    {   
         view = PhotonView.Get(this);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hits >= 3)
        {
             PhotonNetwork.Destroy(this.gameObject);
        }
    }

         void OnCollisionEnter2D(Collision2D coll)
    {
        // If the Collider2D component is enabled on the collided object
        if (coll.transform.tag == "star")
        {
            hits ++;         
        }   
  
        
         
    }
}
