

using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawnGoal : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform[] spawnPointsObstacle;
    public GameObject[] goalPrefabs;
    public GameObject[] obstaclePrefabs;
    public float timeRemaining, timeRemaining2;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = resetTiming();
        timeRemaining2 = resetTiming();
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
        int randGoal = Random.Range(0, goalPrefabs.Length);
        int randSpawnPoint = Random.Range(0,spawnPoints.Length);


        Instantiate(goalPrefabs[randGoal], spawnPoints[randSpawnPoint].position, transform.rotation);    
    }

    void SpawnObstacle(){
        int randObstacle = Random.Range(0, obstaclePrefabs.Length);
        int randSpawnPoint = Random.Range(0,spawnPoints.Length);


        Instantiate(obstaclePrefabs[randObstacle], spawnPointsObstacle[randSpawnPoint].position, transform.rotation);    
    }
    float resetTiming()
    {
        float min = 3, max = 7;
        return Random.Range(min,max);
    }
}