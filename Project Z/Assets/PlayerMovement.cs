using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Joystick movementJoystic;
    public Rigidbody rigidbody;

    public float playerSpeed = 10f;
    public float playerJump = 0f;

    public Vector3 movement = new Vector3(0f, 0f, 0f);

    

    // Update is called once per frame
    void Update()
    {
        movementJoystic = FindObjectOfType<Joystick>();
        rigidbody = FindObjectOfType<Rigidbody>();

        movement.Set(movementJoystic.Horizontal * playerSpeed, 0f * playerJump, movementJoystic.Vertical * playerSpeed);

        rigidbody.velocity = movement;
    }
}
