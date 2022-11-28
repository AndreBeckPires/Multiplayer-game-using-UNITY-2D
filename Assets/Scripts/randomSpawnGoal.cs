

using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class randomSpawnGoal : MonoBehaviour
{
 

    public GameObject[] goalPrefabs;
    public GameObject[] obstaclePrefabs;
    public float timeRemaining, timeRemaining2;
    public float rangeX1, rangeX2,rangeY1,rangeY2,rangeY3,rangeY4;
    public int player;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = resetTiming();
        timeRemaining2 = resetTiming();
        if(PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            player = 1;
            rangeX1 = -19f;
            rangeX2 = 19f;
            rangeY1 = -10f;
            rangeY2 = 0.5f;
            //rangeO = 8;

        }
        else{
            player = 2;
            rangeX1 = -19f;
            rangeX2 = 19f; 
             rangeY3 = 1.60f;
            rangeY4 = 10f;
        }
    }

    // Update is called once per frame
    void Update()
    {   
        TimeCounter();


        
    }
    void TimeCounter(){
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if(timeRemaining < 0){
            SpawnGoal();
            timeRemaining = resetTiming();;
        }
         if(timeRemaining2 > 0)
        {
            timeRemaining2 -= Time.deltaTime;
        }
        if(timeRemaining2 < 0){
            SpawnObstacle();
            timeRemaining2 = resetTiming();
        }
    }
    void SpawnGoal(){
        if(player == 1)
        {
           
            Vector2 pos = new Vector2(Random.Range(rangeX1,rangeX2), Random.Range(rangeY1,rangeY2));
            PhotonNetwork.Instantiate(goalPrefabs[Random.Range(0, 2)].name,pos, Quaternion.identity);  
 
  
        }
        if(player == 2){
             int randGoal = Random.Range(3, 5);

            Vector2 pos = new Vector2(Random.Range(rangeX1,rangeX2), Random.Range(rangeY3,rangeY4));
            PhotonNetwork.Instantiate(goalPrefabs[randGoal].name,pos, Quaternion.identity);   
        }
        
    }

    void SpawnObstacle(){
        if(player == 1)
        {
            int randObstacle = Random.Range(3, 5);
           
           // int randSpawnPoint = Random.Range(0,rangeO);
            Vector2 pos = new Vector2(Random.Range(rangeX1,rangeX2), Random.Range(rangeY1,rangeY2));
            PhotonNetwork.Instantiate(obstaclePrefabs[randObstacle].name, pos, Quaternion.identity);    
       // Instantiate(obstaclePrefabs[randObstacle], spawnPointsObstacle[randSpawnPoint].position, transform.rotation);    
        }
         if(player == 2){
            int randObstacle = Random.Range(0, 2);
           // int randSpawnPoint = Random.Range(0,rangeO);
            Vector2 pos = new Vector2(Random.Range(rangeX1,rangeX2), Random.Range(rangeY3,rangeY4));
            PhotonNetwork.Instantiate(obstaclePrefabs[randObstacle].name, pos, Quaternion.identity);   
        }
        
    }
    float resetTiming()
    {
        float min = 3, max = 7;
        return Random.Range(min,max);
    }
}