using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
        // normalized for movement to be consistant 

    }
 // Anything that should happen to the rigid body should happen in fixed update
    void FixedUpdate(){
        rb.velocity = new Vector2(0,playerDirection.y * playerSpeed);


    }
}
