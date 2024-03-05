using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    //0 = default, 1 = chicken, 2 = fly, 3 = wheel, 4 = fan, 5 = scissors
    public int currentPower = 0;

    public Sprite basic, chicken;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        equipPower();
    }

    public void setPower(int power)
    {
        currentPower = power;
    }

    public int getPower()
    {
        return currentPower;
    }

    public void equipPower()
    {
        switch (currentPower)
        {
            case 0:
                //sprite is normal
                gameObject.GetComponent<SpriteRenderer>().sprite = basic;
                break;
            
            case 1:
                //chicken sprite
                gameObject.GetComponent<SpriteRenderer>().sprite = chicken;
                break;
            
        }
    }
}
