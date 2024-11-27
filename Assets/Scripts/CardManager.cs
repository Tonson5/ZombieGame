using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnCards()
    {
        card1.SetActive(true);
        card2.SetActive(true);
        card3.SetActive(true);
        

        card1.GetComponent<CardItemRandomizer>().Randomize();
        card2.GetComponent<CardItemRandomizer>().Randomize();
        card3.GetComponent<CardItemRandomizer>().Randomize();
    }
    public void DeleteCards()
    {
        card1.SetActive(false);
        card2.SetActive(false);
        card3.SetActive(false);
    }
}
