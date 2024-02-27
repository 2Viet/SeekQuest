using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movementspeed;
    private float moveHorizontal;
    private float moveVertical;
    // Start is called before the first frame update
    void Start()
    {
         rb = gameObject.GetComponent<Rigidbody2D>();
        movementspeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity =new Vector2(Input.GetAxisRaw("Horizontal"), moveVertical = Input.GetAxisRaw("Vertical"))* movementspeed;
       
    }
    void FixedUpdate() 
    {
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f) 
        {
            rb.AddForce(new Vector2(moveHorizontal * movementspeed, 0),ForceMode2D.Impulse);
        }
      
        
    }
}
