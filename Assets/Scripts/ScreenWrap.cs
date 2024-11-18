using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{

    public bool z;
    public GameObject teleportTo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (z)
        {
            other.gameObject.transform.position = new Vector3(teleportTo.transform.position.x, 0, other.gameObject.transform.position.z);
        }
        else
        {
            other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x, 0, teleportTo.transform.position.z);
        }
    }
}
