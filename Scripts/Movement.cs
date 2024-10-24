using UnityEngine;

public class Movement : MonoBehaviour
{
   public float speed = 5f; // Speed of the rover
    private Sprite leftFacingSprite;  // Reference to the sprite for the rover facing left
    private Sprite rightFacingSprite; // Reference to the sprite for the rover facing right

    private SpriteRenderer spriteRenderer;  // Reference to the SpriteRenderer component
    private Animator anim;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        //medium dark (0.706f, 0.4705f, 0.353f, 1.0f)

        //spriteRenderer.color = new Color(0.706f, 0.4705f, 0.353f, 1.0f); // divided by 255.0f
        anim = GetComponent<Animator>();
        anim.SetBool("sprite walking 1", false);
        // Get the SpriteRenderer component
       //spriteRenderer = GetComponent<SpriteRenderer>();

        // Set the initial sprite to facing right
        //spriteRenderer.sprite = rightFacingSprite;
    }
    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        transform.position += movement * speed * Time.deltaTime;

        

        // Check for horizontal input and change the sprite accordingly
        if (moveHorizontal < 0)
        {
            //transform.eulerAngles = new Vector3(0, 180, 0);
            //spriteRenderer.sprite = leftFacingSprite;
            spriteRenderer.flipX = false;
        }
        else if (moveHorizontal > 0)
        {
            //transform.eulerAngles = new Vector3(0, 0, 0); // Normal
            //spriteRenderer.sprite = rightFacingSprite;
            spriteRenderer.flipX = true; 

        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {
            anim.SetBool("isWalking", true);
            anim.Play("spriteWalk1");
        } else {
            anim.SetBool("isWalking", false);
            anim.Play("New State");
        }
    }
}