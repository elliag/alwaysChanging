using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class Level1_Progression : MonoBehaviour
{
    public LoadScenes loadLevel;
    public ButtonWeigh buttonStatus;

    public TMP_Text text1;
    public TMP_Text text2;

    public Player1 p1;
    public Player2 p2;

    public bool p1_done = false;
    public bool p2_done = true;

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
                break;

            case "Tutorial2":
                break;

            case "Tutorial3":
                break;

            case "Level1":
                currentLevel = true;
                text1.text = "Activate the Teleporter!";
                text2.text = "Activate the Teleporter!";
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
            if(buttonStatus.getButtonState() == true)
            {
                p1_done = true;
            }

            if(p1_done && p2_done)
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
