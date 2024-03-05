using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge : MonoBehaviour
{

    public GameObject wallDisappear;
    public GameObject background;
    public GameObject floor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void combineSpaces()
    {
        wallDisappear.SetActive(false);
        background.SetActive(true);
        floor.SetActive(true);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player1" || coll.gameObject.tag == "Player2")
        {
            combineSpaces();
        }
    }
}
