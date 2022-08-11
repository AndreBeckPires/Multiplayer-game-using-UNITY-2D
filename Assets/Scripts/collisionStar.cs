using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionStar : MonoBehaviour
{
    // Start is called before the first frame update
        void OnCollisionEnter2D(Collision2D coll)
    {
        // If the Collider2D component is enabled on the collided object
        if (coll.transform.tag == "Goal")
        {
            // Disables the Collider2D component
            print("colidiu");
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
        }
    }
}
