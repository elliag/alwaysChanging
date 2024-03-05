using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Player1 p1;
    public Player2 p2;

    public int power = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player1")
        {
            checkPower();
            p1.setPower(power);
        }

        if (coll.gameObject.tag == "Player2")
        {
            checkPower();
            p2.setPower(power);
        }
    }

    public void checkPower()
    {
        //0 = default, 1 = chicken, 2 = fly, 3 = wheel, 4 = fan, 5 = scissors
        switch (gameObject.name)
        {
            case "basic":
                power = 0;
                break;

            case "chicken":
                power = 1;
                break;
            
            case "fly":
                power = 2;
                break;

            case "wheel":
                power = 3;
                break;

            case "fan":
                power = 4;
                break;

            case "scissors":
                power = 5;
                break;
        }
    }
}
