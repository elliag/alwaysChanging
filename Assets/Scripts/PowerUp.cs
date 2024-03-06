using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Player1 p1;
    public Player2 p2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player1")
        {
            p1.setPower(checkPower());
        }

        if (coll.gameObject.tag == "Player2")
        {
            p2.setPower(checkPower());
        }
    }

    public int checkPower()
    {
        //0 = default, 1 = chicken, 2 = fly, 3 = wheel, 4 = fan, 5 = scissors
        switch (gameObject.name)
        {
            case "basic":
                return 0;

            case "chicken":
                return 1;
            
            case "fly":
                return 2;

            case "wheel":
                return 3;

            case "fan":
                return 4;

            case "scissors":
                return 5;

            default:
                return 0;
        }
    }
}
