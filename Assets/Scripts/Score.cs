using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshPro score;
    public GameObject player;
    public int scoreHolder;
    public int playerLives;
    public GameObject[] liveHolder;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            gameObject.SetActive(false);
        }
        if (player != null)
        {
            transform.position = player.transform.position;
        }
        score.text = "Score: " + scoreHolder;
        if (playerLives == 2 && liveHolder[2] != null)
        {
            Destroy(liveHolder[2]);
        }
        else if(playerLives == 1 && liveHolder[1] != null)
        {
            Destroy(liveHolder[1]);
        }
        else if(playerLives == 0 && liveHolder[0] != null)
        {
            Destroy(liveHolder[0]);
        }

    }
}
