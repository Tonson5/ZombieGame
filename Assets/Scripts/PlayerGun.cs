using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletSpawn;
    [SerializeField] float bulletVelocity;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        GameObject shot = Instantiate(bullet,bulletSpawn.transform.position,bulletSpawn.transform.rotation);
        shot.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * bulletVelocity,ForceMode.Impulse);
        Destroy(shot.gameObject, 1);
    }
}
