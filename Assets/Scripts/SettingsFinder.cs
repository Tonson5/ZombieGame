using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsFinder : MonoBehaviour
{
    
    public GameObject settings;
    public GameObject screenShakeSlider;
    public bool active;
    void Start()
    {
        settings = GameObject.Find("Settings");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (active)
            {
                active = false;
            }
            else
            {
                active = true;
            }
        }
        if (active)
        {
            settings.SetActive(true);
            
        }
        else
        {
            settings.SetActive(false);
            
        }


    }
    public void Activate()
    {
        active = true;
        Time.timeScale = 0;
    }
    public void Deactivate()
    {
        active = false;
        Time.timeScale = 1;
    }
}
