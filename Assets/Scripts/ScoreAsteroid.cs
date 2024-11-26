using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAsteroid : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    public GameObject score;
    public GameObject particle;
    void Start()
    {
        
        player = GameObject.Find("Player");
        score = GameObject.Find("ui holder");
        gameObject.GetComponent<Rigidbody>().AddForce((transform.position - player.transform.position) * 3, ForceMode.Impulse);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * Random.Range(-1, 1));
        gameObject.GetComponent<Rigidbody>().AddForce(transform.right * Random.Range(-1, 1));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().AddForce((player.transform.position - transform.position) * moveSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("xp Bar").GetComponent<Slider>().value += 5;
            if (GameObject.Find("xp Bar").GetComponent<Slider>().maxValue == GameObject.Find("xp Bar").GetComponent<Slider>().value)
            {
                GameObject.Find("xp Bar").GetComponent<Slider>().maxValue *= 2;
                GameObject.Find("xp Bar").GetComponent<Slider>().value = 0;
            }
            Instantiate(particle,transform.position,transform.rotation);
            score.GetComponent<Score>().scoreHolder += 5;
            Destroy(gameObject);
        }
    }
}
