using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float maxSpeed;
    public int size;
    public GameObject asteroid;
    public GameObject score;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.rotation = new Quaternion(0, Random.Range(0, 360),0,0);
        rb.AddForce(new Vector3(Random.Range(-maxSpeed, maxSpeed), 0, Random.Range(-maxSpeed, maxSpeed)),ForceMode.Impulse);
        rb.AddTorque(Vector3.up * Random.Range(0, 2),ForceMode.Impulse);
        rb.AddTorque(Vector3.right * Random.Range(0, 2),ForceMode.Impulse);
        rb.AddTorque(Vector3.forward * Random.Range(0, 2),ForceMode.Impulse);
        score = GameObject.Find("ui holder");
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(size,size,size);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            score.GetComponent<Score>().scoreHolder += 50;
            Destroy(collision.gameObject);
            if (size == 1)
            {
                Destroy(gameObject);
            }
            else
            {
                Instantiate(asteroid, transform.position, transform.rotation).GetComponent<AsteroidMovement>().size = size - 1;
                Instantiate(asteroid, transform.position, transform.rotation).GetComponent<AsteroidMovement>().size = size - 1;
                Destroy(gameObject);
            }
            
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (score.GetComponent<Score>().playerLives == 0)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                score.GetComponent<Score>().playerLives -= 1;
                Destroy(gameObject);
            }
        }
    }
}
