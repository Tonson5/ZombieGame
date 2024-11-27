using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CardItemRandomizer : MonoBehaviour
{
    public string[] common;
    public int[] commonSkill;
    public string[] rare;
    public int[] rareSkill;
    public string[] legendary;
    public int[] legendarySkill;
    public int myRarity;
    public int designator;
    public string displayText;
    public int skillToChange;
    public GameObject player;
    public PlayerMovment playerMoveScript;
    public PlayerGun playerShootScript;
    public TextMeshProUGUI cardText;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerMoveScript = player.GetComponent<PlayerMovment>();
        playerShootScript = player.GetComponent<PlayerGun>();
        Randomize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Randomize()
    { 
        myRarity = Random.Range(1,3);
        if (myRarity > 1)
        {
            myRarity = Random.Range(1, 3);
        }
        if (myRarity > 2)
        {
            myRarity = Random.Range(1, 3);
        }
        if (myRarity == 1)
        {
            designator = Random.Range(0, common.Length);
            displayText = common[designator];
            skillToChange = commonSkill[designator];
        }
        else if (myRarity == 2)
        {
           designator = Random.Range(0, rare.Length);
           displayText = rare[designator];
           skillToChange = rareSkill[designator];
        }
        else if (myRarity == 3)
        {
           designator = Random.Range(0, legendary.Length);
           displayText = legendary[designator];
           skillToChange = legendarySkill[designator];
        }
        cardText.text = displayText;
    }
    public void ButtonPressed()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
        GameObject.Find("CardManager").GetComponent<CardManager>().DeleteCards();
    }
}
