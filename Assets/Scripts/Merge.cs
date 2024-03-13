using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge : MonoBehaviour
{

    public GameObject wallDisappear;
    public GameObject background;
    public GameObject floor;

    public bool mergeStatus = false;

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
        setMergeStatus(true);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player1" || coll.gameObject.tag == "Player2")
        {
            combineSpaces();
        }
    }

    public bool getMergeStatus(){
        return mergeStatus;
    }

    public void setMergeStatus(bool status){
        mergeStatus = status;
    }
}
