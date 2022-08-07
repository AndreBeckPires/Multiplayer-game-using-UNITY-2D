

using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomObstacle : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] goalPrefabs;
    public float timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = Random.Range(3,12);
    }

    // Update is called once per frame
    void Update()
    {   
        TimeCounter();
        print(timeRemaining);


        
    }
    void TimeCounter(){
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if(timeRemaining < 0){
            SpawnObstacle();
            timeRemaining = Random.Range(3,12);
        }
    }
    void SpawnObstacle(){
        int rangGoal = Random.Range(0, goalPrefabs.Length);
        int randSpawnPoint = Random.Range(0,spawnPoints.Length);


        Instantiate(goalPrefabs[rangGoal], spawnPoints[randSpawnPoint].position, transform.rotation);    
    }
}