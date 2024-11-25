using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletSpawn;
    [SerializeField] float bulletVelocity;
    [SerializeField] GameObject audioScource;
    [SerializeField] AudioClip shoot;
    private CinemachineImpulseSource _impulseScource;
    void Start()
    {
        _impulseScource = GetComponent<CinemachineImpulseSource>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.timeScale == 1)
        {
            Shoot();
            audioScource.GetComponent<AudioSource>().PlayOneShot(shoot);
        }
    }

    public void Shoot()
    {
        _impulseScource.GenerateImpulse();
        GameObject shot = Instantiate(bullet,bulletSpawn.transform.position,bulletSpawn.transform.rotation);
        shot.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * bulletVelocity,ForceMode.Impulse);
        Destroy(shot.gameObject, 0.5f);
    }
}
