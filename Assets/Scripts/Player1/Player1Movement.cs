using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{

    public Player1 p1;

    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 30f;
    private bool isFacingRight = true;

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

        if (Input.GetKeyDown(KeyCode.W) && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetKeyDown(KeyCode.W) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        flip();

        //if chicken ability is equipped
        if (Input.GetKeyDown(KeyCode.E) && p1.getPower() == 1)
        {
            Instantiate(egg, gameObject.transform.position, Quaternion.identity, uiCanvas.transform);
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

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 02f, groundLayer);
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

}