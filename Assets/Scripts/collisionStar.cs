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
    // Start is called before the first frame update
        void OnCollisionEnter2D(Collision2D coll)
    {
        // If the Collider2D component is enabled on the collided object
        if (coll.transform.tag == "Goal")
        {
             print("colidiu");
            PhotonNetwork.Destroy(coll.gameObject);
            PhotonNetwork.Destroy(this.gameObject);
            obj.GetComponent<pointsCounter>().points++;
            // Disables the Collider2D component
           
        }
    }
}
