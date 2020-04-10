using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToHome()
    {
        SceneManager.LoadScene("Home");
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void ExitTheGame()
    {
        Application.Quit();
    }
}
