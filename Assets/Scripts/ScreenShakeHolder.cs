using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class ScreenShakeHolder : MonoBehaviour
{
    public GameObject settings;
    void Start()
    {
        settings = GameObject.Find("settingsHolder");
    }

    // Update is called once per frame
    void Update()
    {
       GetComponent<CinemachineImpulseListener>().m_Gain = settings.GetComponent<SettingsFinder>().screenShakeSlider.GetComponent<Slider>().value;
    }
}
