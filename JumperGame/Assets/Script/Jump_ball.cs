using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump_ball : MonoBehaviour
{
    public float speed;
    public GameObject pertical;
    bool add_force;
        
    public string LevelToload;

    public Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        add_force = true;

    
    }

    // Update is called once per frame
    void Update()
    {
        //CameraFollow_Code
        if(transform.position.y + 0.200f < Camera.main.transform.position.y)
        {
            Vector3 pos = Camera.main.transform.position;
            pos.y = transform.position.y + 0.200f;
            Camera.main.transform.position = pos;
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        //BallJump&PerticalEffect
        if(collision.gameObject.tag == "plateform" && add_force)
        {
            add_force = false;
            Invoke("creat",0.1f);

            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1f, 0) * Time.deltaTime * speed);


            GameObject Splash = Instantiate(pertical);
            Vector3 pos =transform.position;
            pos.y = pos.y-0.06f;
            Splash.transform.position = pos;
            Splash.transform.SetParent(GameObject.Find("Helix").transform);

        }
        //Scenes_Change_Code
        else if (collision.gameObject.tag == "GameOver")
        {
            Application.LoadLevel(LevelToload);
        }
        
    }
        
    void creat()
    {
        add_force = true;
    }
}
