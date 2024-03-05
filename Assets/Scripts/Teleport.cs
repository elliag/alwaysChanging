using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform pinkSpawn;
    public Transform blueSpawn;
    

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player1" || coll.gameObject.tag == "Player2")
        {
            switch(gameObject.tag)
            {
                case "PinkTeleport":
                    coll.gameObject.transform.position = pinkSpawn.position;
                    break;

                case "BlueTeleport":
                    coll.gameObject.transform.position = blueSpawn.position;
                    break;

                default:
                    break;
            }
        }
    }

    
}
