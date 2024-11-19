using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public int asteroids;
    public int wave = 1;
    public GameObject[] spawns;
    public GameObject enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        asteroids = GameObject.FindObjectsOfType<AsteroidMovement>().Length;
        if (asteroids == 0)
        {
            wave += 1;
            for (int i = 0; i < wave;)
            {
                int size = 1;

                if (i >= 3)
                {
                    size = 3;
                }
                else if (i >= 2)
                {
                    size = 2;
                }
                Instantiate(enemy, spawns[Random.Range(0, spawns.Length)].transform.position, spawns[Random.Range(0, spawns.Length)].transform.rotation).GetComponent<AsteroidMovement>().size = size;
                i += size;
            }
        }
    }
}
