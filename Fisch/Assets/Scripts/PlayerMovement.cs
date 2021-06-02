using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementForce = 10f;


    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        //get our rigidbody that we will need to find the physics information
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //find out from the rigidbody what our current horizontal and vertical speeds are 
        float currentSpeedH = ourRigidbody.velocity.x;
        float currentSpeedV = ourRigidbody.velocity.y;
       

        // Condition when the player presses D...
        if (Input.GetKey(KeyCode.D) == true)
        {
            // Action: Apply a force (move the player)


            // Add a force to the rigid body to move our player
            ourRigidbody.AddForce(Vector2.right * movementForce);
        }

        // Condition when the player presses A...
        if (Input.GetKey(KeyCode.A) == true)
        {
            // Action: Apply a force (move the player)



            // Add a force to the rigid body to move our player
            ourRigidbody.AddForce(Vector2.left * movementForce);
        }

        // Condition when the player presses W...
        if (Input.GetKey(KeyCode.W) == true)
        {
            // Action: Apply a force (move the player)



            // Add a force to the rigid body to move our player
            ourRigidbody.AddForce(Vector2.up * movementForce);
        }

        // Condition when the player presses S...
        if (Input.GetKey(KeyCode.S) == true)
        {
            // Action: Apply a force (move the player)



            // Add a force to the rigid body to move our player
            ourRigidbody.AddForce(Vector2.down * movementForce);
        }
    }


}
