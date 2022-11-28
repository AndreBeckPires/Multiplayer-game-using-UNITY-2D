using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class collisionStar : MonoBehaviour
{
     public GameObject obj;
    PhotonView view;
     void Awake(){
        obj = GameObject.FindGameObjectWithTag("Counter");
     }
     void Start(){
       view = PhotonView.Get(this);
     }
    // Start is called before the first frame update
 
        void OnCollisionEnter2D(Collision2D coll)
    {
        // If the Collider2D component is enabled on the collided object
        if (coll.transform.tag == "Goal")
        {
  
            if(GetComponent<PhotonView>().IsMine)
            {
            PhotonNetwork.Destroy(coll.gameObject);
            PhotonNetwork.Destroy(this.gameObject);
            }
           
           // view.RPC("increment1", RpcTarget.AllBuffered);
            // Disables the Collider2D component          
        }   
        if (coll.transform.tag == "BOX")
        {            
            PhotonNetwork.Destroy(this.gameObject);
            // Disables the Collider2D component    
        }
             if (coll.transform.tag == "Goal2")
        {
  
            PhotonNetwork.Destroy(coll.gameObject);
            PhotonNetwork.Destroy(this.gameObject);
            //view.RPC("increment2", RpcTarget.AllBuffered);
            // Disables the Collider2D component          
        }   

        
         
    }

  
    }
