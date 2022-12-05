

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class shoot : MonoBehaviour
{
    public GameObject[] starPrefab;
    public Transform firePoint;
    public Vector3 pos;
    public float bulletForce = 20f;
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine)
        {
            pos = transform.position;
            if (Input.GetMouseButtonDown(0))
            {
                trigger();
            
            }
        }
        
           
    }
    void trigger(){
     
        if(this.gameObject.tag == "Player1")
        {
        GameObject bullet =  PhotonNetwork.Instantiate(starPrefab[0].name, pos, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
     
        //bullet.tag = "star2";
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
        else
        {
        GameObject bullet =  PhotonNetwork.Instantiate(starPrefab[1].name, pos, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
     
      //  bullet.tag = "star2";
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }
       
}
