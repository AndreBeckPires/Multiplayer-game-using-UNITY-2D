using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerPrefab;
    public GameObject newPrefab;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start() 
    {
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        newPrefab = PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        if(PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
            newPrefab.tag = "Player1";
            
        }
        else{
            newPrefab.tag = "Player0";

        }
    }

}
