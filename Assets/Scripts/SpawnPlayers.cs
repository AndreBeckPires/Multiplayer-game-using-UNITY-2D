using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerPrefab,playerPrefab2 ;
    public GameObject newPrefab;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start() 
    {
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        
        if(PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {   
            Vector2 pos = new Vector2(-0.06f, 6.14f);
            newPrefab = PhotonNetwork.Instantiate(playerPrefab.name, pos, Quaternion.identity);
          
            
        }
        else{
            
             Vector2 pos = new Vector2(-1.397282f, -5.053027f);
            newPrefab = PhotonNetwork.Instantiate(playerPrefab2.name, pos, Quaternion.identity);
       

        }
    }

}
