using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropThroughPlatform : MonoBehaviour
{

    private Collider2D colliderObject;
    private bool platform;

    private string player = "";


    // Start is called before the first frame update
    void Start()
    {
        colliderObject = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(platform && Input.GetKeyUp(KeyCode.S) && player.Equals("Player1"))
        {
            colliderObject.enabled = false;
            StartCoroutine(EnableCollider());
        }
        else if(platform && Input.GetKeyUp(KeyCode.DownArrow) && player.Equals("Player2"))
        {
            colliderObject.enabled = false;
            StartCoroutine(EnableCollider());
        }
    }
    
    private IEnumerator EnableCollider()
    {
        yield return new WaitForSeconds(0.5f);
        colliderObject.enabled = true;
    }

    private void SetPlayerOnPlatform(Collision2D coll, bool value)
    {

        if(coll.gameObject.tag == "Player1" || coll.gameObject.tag == "Player2")
        {
            platform = value;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        player = other.gameObject.tag;
        SetPlayerOnPlatform(other, true);

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        SetPlayerOnPlatform(other, false);
    }
}
