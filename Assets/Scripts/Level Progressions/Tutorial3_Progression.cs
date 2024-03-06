using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class Tutorial3_Progression : MonoBehaviour
{
    public LoadScenes loadLevel;

    public TMP_Text text1;
    public TMP_Text text2;

    public Player1 p1;
    public Player2 p2;

    public bool p1_done = false;
    public bool p2_done = false;

    public bool p1_equip = false;
    public bool p2_equip = false;

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
                currentLevel = true;
                text1.text = "Absorb the Form Goo";
                text2.text = "Absorb the Form Goo";
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
            if(p1.getPower() == 0)
            {
                text1.text = "Absorb the Form Goo";
                p1_equip = false;
            }

            if(p2.getPower() == 0)
            {
                text2.text = "Absorb the Form Goo";
                p2_equip = false;
            }

            if(p1.getPower() == 1 && p1_equip == false)
            {
                text1.text = "Press 'E' to Interact";
                p1_equip = true;
            }

            if(p2.getPower() == 1 && p2_equip == false)
            {
                text2.text = "Press 'Shift' to Interact";
                p2_equip = true;
            }

            if(Input.GetKeyDown(KeyCode.E) && p1_equip == true)
            {
                text1.text = "Hold 'S' to Drop the Form";
                p1_done = true;
            }

            if(Input.GetKeyDown(KeyCode.RightShift) && p2_equip == true)
            {
                text2.text = "Hold 'Down' to Drop the Form";
                p2_done = true;
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

    public void setLevelStatus(){
        levelDone = false;
    }
}
