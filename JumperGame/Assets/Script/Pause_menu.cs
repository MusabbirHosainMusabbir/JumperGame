using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause_menu : MonoBehaviour
{

    bool ispaused = false;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pausedGame()
    {
        if (ispaused)
        {
            Time.timeScale = 1;
            ispaused = false;
          
        }
        else
        {
            Time.timeScale = 0;
            ispaused = true;
          
        }

    }
   
}
