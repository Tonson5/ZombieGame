using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] float turnSpeed;
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject restartButton;
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
        rb.AddRelativeForce(Vector3.forward * moveSpeed * Input.GetAxisRaw("Vertical"));
        
    }
    private void OnDestroy()
    {
        restartButton.SetActive(true);
    }
}
