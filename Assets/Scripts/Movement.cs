using System.Collections;
using System.Collections.Generic;

//make sure to add a CharacterController to the thing that you want to move
using UnityEngine;

public class Movement : MonoBehaviour
{
    CharacterController characterController;
    PlayerInteraction playerInteraction;

    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float speed = 9.0f;

    private Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();

        playerInteraction = GetComponentInChildren<PlayerInteraction>();
    }

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));

       // if (characterController.isGrounded)
        {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            Interact();

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
       // moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
    public void Interact()
    {
        //fire1 means that when the player clicks there will be an interaction if the land is harvestable
        if (Input.GetButtonDown("Fire1"))
        {
            playerInteraction.Interact();
        }
    }
}