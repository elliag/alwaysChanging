using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class Tutorial1_Progression : MonoBehaviour
{
    public LoadScenes loadLevel;

    public TMP_Text text1;
    public TMP_Text text2;

    public Player1 p1;
    public Player2 p2;

    public bool p1_done = false;
    public bool p2_done = false;

    public bool levelDone = false;

    public bool currentLevel = false;

    // Start is called before the first frame update
    void Start()
    {
        switch (loadLevel.getScene())
        {
            case "Main_Menu":
                break;

            case "Tutorial1":
                currentLevel = true;
                text1.text = "Absorb the blue ooz!";
                text2.text = "Absorb the pink ooz!";
                break;

            case "Tutorial2":
                break;

            case "Tutorial3":
                break;

            default:
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(currentLevel == true)
        {
            if(p1.getSpace() == 2)
            {
                p1_done = true;
            }

            if(p2.getSpace() == 1)
            {
                p2_done = true;
            }

            if(p1_done == true && p2_done == true)
            {
                levelDone = true;
            }
        }
    }

    public bool getLevelStatus()
    {
        return levelDone;
    }

    public void setLevelStatus(bool status){
        levelDone = status;
    }
}
