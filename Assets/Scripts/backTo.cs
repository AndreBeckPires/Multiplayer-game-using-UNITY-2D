using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class backTo : MonoBehaviour
{
    PhotonView view;
    int teste;
    // Start is called before the first frame update
    void Start()
    {
          view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void backToLobby(){
        
        PhotonNetwork.LeaveRoom();
        SceneManager.LoadScene("Lobby");
    }

}
