using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class movementscript : MonoBehaviour
{
    // Start is called before the first frame update
   public float speed = 10.5f; 
   bool check1 = false, check2 = false;
   int numOfP;
   PhotonView view;
   public float time;
   public Text timerText;
    public bool contar;
  public  Text endgame;
   public GameObject canvas;
    // Update is called once per frame
   
    private void Start(){
        view = GetComponent<PhotonView>();
        Debug.Log(PhotonNetwork.LocalPlayer.ActorNumber);
        time = 45f;
        contar = false;
        timerText = GameObject.Find("Canvas/Text").GetComponent<Text>();
        canvas = GameObject.Find("Canvas2");
         endgame = GameObject.Find("Canvas2/endgame").GetComponent<Text>();
         canvas.SetActive(false);
         endgame.text = "oi";
        
    }
    void Update()
    {
       
        if(view.IsMine)
        {
            Vector3 pos = transform.position;
            Vector3 mousePosition = (Camera.main.ScreenToWorldPoint(Input.mousePosition));
            Vector2 direction = (mousePosition - transform.position).normalized;

            timerText.text = time.ToString("F0");
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

             if(contar)
        {
            time -= Time.deltaTime;
            Debug.Log(time);
            if(time <= 0)
            {
               // PhotonNetwork.LeaveRoom();
            canvas.SetActive(true);

              
            }
        }

        if(PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {   
          
            contar = true;
        }
        
        }
       
    }

}
