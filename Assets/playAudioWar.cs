using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class playAudioWar : MonoBehaviour
{
     public AudioSource audioWar;
    PhotonView view;
    bool tocando;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        audioWar = this.GetComponent<AudioSource>();
        tocando = false;
    }

    // Update is called once per frame
    void Update()
    {
         if(PhotonNetwork.CurrentRoom.PlayerCount == 2 && tocando == false)
        {     
            audioWar.Play(0);
            tocando = true;
        }
    }
}
