using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel_Player2 : MonoBehaviour
{

    public LoadScenes loadLevel;
    public FinishLevel_Player1 player1;

    public Tutorial3_Progression t3;

    private bool playerReady = false;

    public bool startTimer = false;
    public float timer = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (playerReady == true && player1.getReady() == true)
        {
            if(checkProgression() == true)
            {
                startTimer = true;
    
                if (startTimer)
                {
                    timer -= 3.0f * Time.deltaTime;
    
                    if (timer <= 0.0f)
                    {
                        loadingNextLevel();
                        startTimer = false;
                    
                    }
                }
            }
        }

        if(playerReady == false || player1.getReady() == false)
        {
            timer = 3.0f;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player2")
        {
            playerReady = true;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player2")
        {
            playerReady = false;
        }
    }

    public bool getReady()
    {
        return playerReady;
    }

    public void loadingNextLevel()
    {
        switch (loadLevel.getScene())
        {
            case "Main_Menu":
                loadLevel.LoadTutorial1();
                break;

            case "Tutorial1":
                loadLevel.LoadTutorial2();
                break;

            case "Tutorial2":
                loadLevel.LoadTutorial3();
                break;

            default:
                break;

        }
    }

    public bool checkProgression()
    {
        switch (loadLevel.getScene())
        {
            case "Main_Menu":
                return false;

            case "Tutorial1":
                return false;

            case "Tutorial2":
                return false;

            case "Tutorial3":
                return t3.getLevelStatus();

            default:
                return false;

        }
    }
}
