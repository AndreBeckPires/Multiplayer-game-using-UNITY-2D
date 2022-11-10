using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class pointsCounter : MonoBehaviour
{
    PhotonView view;
    public float points1,points2;
    public Text scoreText, scoreText2;
    // Start is called before the first frame update
    void Awake(){
       
    }
    void Start()
    {

    }

    void Update()
    {   
        scoreText.text = "Score : " + points1;
        
        scoreText2.text = "Score : " + points2; 
           
    }


}
