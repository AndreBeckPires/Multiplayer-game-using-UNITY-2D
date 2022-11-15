using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject selectedSkin;
    public GameObject Player;

    private Sprite playersprite;
    // Start is called before the first frame update
    void Start()
    {
        playersprite = selectedSkin.GetComponent<SpriteRenderer>().sprite;

        Player.GetComponent<SpriteRenderer>().sprite = playersprite;
    }

    // Update is called once per frame
   
}
