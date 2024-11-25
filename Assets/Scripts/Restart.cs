using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
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
                RestartGame();
            }
        }
    }
    public void RestartGame()
    {
        Debug.Log("hi");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
