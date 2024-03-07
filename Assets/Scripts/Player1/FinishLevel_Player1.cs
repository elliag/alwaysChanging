using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel_Player1 : MonoBehaviour
{

    public LoadScenes loadLevel;
    public FinishLevel_Player2 player2;

    public Tutorial1_Progression t1;
    public Tutorial2_Progression t2;
    public Tutorial3_Progression t3;
    public Level1_Progression l1;
    

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

         if (playerReady == true && player2.getReady() == true)
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

        if(playerReady == false || player2.getReady() == false)
        {
            timer = 3.0f;
        }
    }

    public bool getReady()
    {
        return playerReady;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player1")
        {
            playerReady = true;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player1")
        {
            playerReady = false;
        }
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

            case "Tutorial3":
                loadLevel.LoadLevel1();
                break;

            case "Level1":
                //loadLevel.LoadLevel2();
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
                return true;

            case "Tutorial1":
                return t1.getLevelStatus();

            case "Tutorial2":
                return t2.getLevelStatus();

            case "Tutorial3":
                return t3.getLevelStatus();

            case "Level1":
                return l1.getLevelStatus();;

            default:
                return false;

        }
    }
}
