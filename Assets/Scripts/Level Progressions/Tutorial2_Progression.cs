using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class Tutorial2_Progression : MonoBehaviour
{
    public LoadScenes loadLevel;

    public TMP_Text text1;
    public TMP_Text text2;

    public Merge mergeCheck;

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
                currentLevel = true;
                text1.text = "Absorb the Merge ooz!";
                text2.text = "";
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
            if(mergeCheck.getMergeStatus() == true)
            {
                text1.text = "";
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
