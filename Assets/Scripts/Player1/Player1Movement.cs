using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{

    public Player1 p1;

    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 11f;
    private bool isFacingRight = true;
    private bool hasJumped = false;

    //vars for chicken ability
    public GameObject egg;
    public Canvas uiCanvas;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    public bool startTimer = false;
    public float timer = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Only move left/right if A or D keys are pressed
        horizontal = Input.GetKey(KeyCode.A) ? -1f : Input.GetKey(KeyCode.D) ? 1f : 0f;

        if(hasJumped == false){
            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            }
        }

        flip();

        //if chicken ability is equipped
        if (Input.GetKeyDown(KeyCode.E) && p1.getPower() == 1)
        {
            Instantiate(egg, gameObject.transform.position, Quaternion.identity, uiCanvas.transform);
        }

        //if chicken ability is equipped
        if (Input.GetKey(KeyCode.E) && p1.getPower() == 2)
        {
            rb.velocity = rb.velocity.x, speed * -1f;
        }

        //check if power not equal 0 then drp
        if(Input.GetKey(KeyCode.S) && p1.getPower() != 0){
            startTimer = true;
    
                if (startTimer)
                {
                    timer -= 3.0f * Time.deltaTime;
    
                    if (timer <= 0.0f)
                    {
                        p1.setPower(0);
                        startTimer = false;
                    
                    }
                }
        }

        if(Input.GetKeyUp(KeyCode.S))
        {
            timer = 3.0f;
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //check if collided with ground layer
        if (coll.gameObject.layer == 6)
        {
            hasJumped = false;
        }
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.layer == 6)
        {
            hasJumped = true;
        }
    }

}
