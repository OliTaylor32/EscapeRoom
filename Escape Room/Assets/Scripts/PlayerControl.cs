using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed,turnSpeed;
    public float mouseX, mouseY;
    CharacterController charController;
    public AudioSource footsteps;
    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = true; //Lock the moust to the center of the screen
        charController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        bool walking = false;
        if (Input.GetKey(KeyCode.W)) //Walk forward
        {
            Vector3 direction = transform.TransformDirection(Vector3.forward);
            charController.SimpleMove(direction * moveSpeed);
            walking = true;
        }

        if (Input.GetKey(KeyCode.S)) //Walk Backwards
        {
            Vector3 direction = transform.TransformDirection(Vector3.back);
            charController.SimpleMove(direction * moveSpeed);
            walking = true;
        }

        if (Input.GetKey(KeyCode.A)) //Strafe to the left
        {
            Vector3 direction = transform.TransformDirection(Vector3.left);
            charController.SimpleMove(direction * moveSpeed);
            walking = true;
        }

        if (Input.GetKey(KeyCode.D)) //Strafe to the right
        {
            Vector3 direction = transform.TransformDirection(Vector3.right);
            charController.SimpleMove(direction * moveSpeed);
            walking = true;
        }

        //Allow the player to look around by moving the mouse.
        mouseX += Input.GetAxis("Mouse X") * turnSpeed;
        mouseY += Input.GetAxis("Mouse Y") * turnSpeed;

        transform.localRotation = Quaternion.Euler(-mouseY, mouseX, 0); //Looks around by rotating the player (camera)

        if (walking == true) //If moving then play footfall sound.
        {
            footsteps.UnPause();
        }
        else
        {
            footsteps.Pause();
        }
    }
}
