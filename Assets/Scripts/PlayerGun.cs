using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletSpawn;
    [SerializeField] float bulletVelocity;
    [SerializeField] GameObject audioScource;
    [SerializeField] AudioClip shoot;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
            audioScource.GetComponent<AudioSource>().PlayOneShot(shoot);
        }
    }

    public void Shoot()
    {
        GameObject shot = Instantiate(bullet,bulletSpawn.transform.position,bulletSpawn.transform.rotation);
        shot.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * bulletVelocity,ForceMode.Impulse);
        Destroy(shot.gameObject, 0.5f);
    }
}
