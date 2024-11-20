using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshPro score;
    public GameObject player;
    public int scoreHolder;
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
        transform.position = player.transform.position;
        score.text = "Score: " + scoreHolder;
        
    }
}
