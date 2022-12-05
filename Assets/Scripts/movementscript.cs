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
   public float time, time2;
   public Text timerText;
    public bool contar;
  public  Text endgame;
   public GameObject canvas;
   public int pontos = 0;
   public AudioSource audioPaz;
   public  Text Waiting;
   public GameObject canvas3;
   
    // Update is called once per frame
   
    private void Start(){
        view = GetComponent<PhotonView>();
        Debug.Log(PhotonNetwork.LocalPlayer.ActorNumber);
        time = 45f;
        time2 = 5f;
        contar = false;
        timerText = GameObject.Find("Canvas/Text").GetComponent<Text>();
        canvas = GameObject.Find("Canvas2");
         endgame = GameObject.Find("Canvas2/endgame").GetComponent<Text>();
         canvas.SetActive(false);
         canvas3 = GameObject.Find("Canvas3");
         Waiting = GameObject.Find("Canvas3/Text").GetComponent<Text>();
         pontos = 0;
        audioPaz = GetComponent<AudioSource>();
        audioPaz.Play(0);
       
        
    }
    void Update()
    {
        if(PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {     
            contar = true;
           time2 -= Time.deltaTime;
            Waiting.text = time2.ToString("F0");
            if(time2 <= 0)
            {
                canvas3.SetActive(false);
                this.gameObject.GetComponent<randomSpawnGoal>().playing=true;
            }
        }
        endgame.text = "Sua Pontuação: " + pontos.ToString();
        if(time2 <= 0)
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
            PhotonNetwork.LeaveRoom();
            canvas.SetActive(true);


              
            }
        }


        
        }
        }
        
       
    }

     void OnCollisionEnter2D(Collision2D coll)
    {
         if(this.gameObject.tag == "Player1" && coll.transform.tag == "star2")
         {
            pontos--;
           
         }
        if(this.gameObject.tag == "Player2" && coll.transform.tag == "star")
         {
            pontos--;
         }
    }

}
