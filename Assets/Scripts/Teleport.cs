using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform pinkSpawn;
    public Transform blueSpawn;

    public Player1 p1;
    public Player2 p2;
    

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player1" || coll.gameObject.tag == "Player2")
        {
            switch(gameObject.tag)
            {
                case "PinkTeleport":
                    coll.gameObject.transform.position = pinkSpawn.position;

                    if(coll.gameObject.tag == "Player1")
                    {
                        //1 for pink, 2 for blue
                        p1.setSpace(1);
                    }
                    else if (coll.gameObject.tag == "Player2")
                    {
                        //1 for pink, 2 for blue
                        p2.setSpace(1);
                    }

                    break;

                case "BlueTeleport":
                    coll.gameObject.transform.position = blueSpawn.position;

                    if(coll.gameObject.tag == "Player1")
                    {
                        //1 for pink, 2 for blue
                        p1.setSpace(2);
                    }
                    else if (coll.gameObject.tag == "Player2")
                    {
                        //1 for pink, 2 for blue
                        p2.setSpace(2);
                    }

                    break;

                default:
                    break;
            }
        }
    }

    
}
