using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class detroy : MonoBehaviour
{   
    PhotonView view;
    public float timeRemaining;
  
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        timeRemaining = resetTiming();
         TimeCounter();
    }

    // Update is called once per frame
    void Update()
    {
         if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
              if(timeRemaining < 0)
        {
            timeRemaining -= Time.deltaTime;
            Debug.Log("aa");
            PhotonNetwork.Destroy(this.gameObject);
        }
    }
    void TimeCounter(){
       
        if(timeRemaining < 0){
           
            detroyGoal();
            timeRemaining = resetTiming();
        }
    }
    void detroyGoal(){
         PhotonNetwork.Destroy(this.gameObject);
    }
     float resetTiming()
    {
        float min = 3, max = 7;
        return Random.Range(min,max);
    }
}
