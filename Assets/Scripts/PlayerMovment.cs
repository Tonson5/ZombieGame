using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float turnSpeed;
    public float moveSpeed;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject restartButton;
    [SerializeField] GameObject audioScource;
    [SerializeField] GameObject thrust;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    void Update()
    {
    }
    private void FixedUpdate()
    {
        MovePlayer();
        RotatePlayer();
    }
    public void RotatePlayer()
    {
        rb.AddTorque(Vector3.up * turnSpeed * Input.GetAxisRaw("Horizontal"));
    }

    public void MovePlayer()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            rb.AddRelativeForce(Vector3.forward * moveSpeed * Input.GetAxisRaw("Vertical"));
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            thrust.SetActive(true);
            audioScource.SetActive(true);
        }
        else
        {
            thrust.SetActive(false);
            audioScource.SetActive(false);
        }
    }
    private void OnDestroy()
    {
        restartButton.SetActive(true);
    }
}
