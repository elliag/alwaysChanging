using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWeigh : MonoBehaviour
{

    // to change color of button, will change later > check player1 script for sprite changing code
    private SpriteRenderer spriteRenderer;

    public GameObject button;

    private BoxCollider2D boxCollider;

    public bool buttonPressed;

    public int inContact = 0;

    private bool p1OnButton = false;
    private bool p2OnButton = false;

    



    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = button.GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();

        buttonPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        buttonState(inContact);

        if(inContact < 0)
        {
            inContact = 0;
        }
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {

        if(coll.gameObject.tag == "egg")
        {
            inContact++;
            // Resize the BoxCollider2D
            ResizeCollider(new Vector2(boxCollider.size.x, boxCollider.size.y + ((BoxCollider2D)coll).size.y + 1f));
            boxCollider.offset = (new Vector2(boxCollider.offset.x, boxCollider.offset.y + 0.5f));
        }
    
    }

    void OnTriggerExit2D(Collider2D coll){
        if(coll.gameObject.tag == "egg")
        {
            inContact--;
        }
    }

    // Function to resize the BoxCollider2D
    void ResizeCollider(Vector2 newSize)
    {
        // Set the size of the BoxCollider2D
        boxCollider.size = newSize;
    }

    public void buttonState(int x){

        switch(x)
        {
            case 0:
                spriteRenderer.color = Color.white;
                break;
            
            case 1:
                spriteRenderer.color = Color.red;
                break;
            
            case 2: 
                spriteRenderer.color = Color.yellow;
                break;

            case 3:
                spriteRenderer.color = Color.green;
                break;
            
            case 4:
                buttonPressed = true;
                break;

            default:
                break;
        }
        
    }

    public bool getButtonState(){
        return buttonPressed;
    }
}
