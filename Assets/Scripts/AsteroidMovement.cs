using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float maxSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.rotation = new Quaternion(0, Random.Range(0, 360),0,0);
        rb.AddForce(new Vector3(Random.Range(-maxSpeed, maxSpeed), 0, Random.Range(-maxSpeed, maxSpeed)),ForceMode.Impulse);
        rb.AddTorque(Vector3.up * Random.Range(0, 30),ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }
}
