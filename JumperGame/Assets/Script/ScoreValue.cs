using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreValue : MonoBehaviour
{
    public int scorevalue;

    // Start is called before the first frame update
    void Start()
    {
        scorevalue = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "score")
        {
            Score_Manager.score += scorevalue;
        }
    }
}
