

using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawnGoal : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
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
            SpawnGoal();
            timeRemaining = Random.Range(3,12);
        }
    }
    void SpawnGoal(){
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0,spawnPoints.Length);


        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);    
    }
}
