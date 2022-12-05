using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class playAudios : MonoBehaviour
{
    public AudioSource audioPaz;
    PhotonView view;
    
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        audioPaz = this.GetComponent<AudioSource>();
        audioPaz.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(PhotonNetwork.CurrentRoom.PlayerCount != 1)
        {     
            audioPaz.Pause();
        }
    }
}
