using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string scene;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                LoadGame();
            }
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton8))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            LoadGame();
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(scene);
    }
}
