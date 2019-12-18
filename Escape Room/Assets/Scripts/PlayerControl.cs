using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed,turnSpeed;
    public float mouseX, mouseY;
    CharacterController charController;
    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = true;
        charController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direction = transform.TransformDirection(Vector3.forward);
            charController.SimpleMove(direction * moveSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 direction = transform.TransformDirection(Vector3.back);
            charController.SimpleMove(direction * moveSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 direction = transform.TransformDirection(Vector3.left);
            charController.SimpleMove(direction * moveSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 direction = transform.TransformDirection(Vector3.right);
            charController.SimpleMove(direction * moveSpeed);
        }

        mouseX += Input.GetAxis("Mouse X") * turnSpeed;
        mouseY += Input.GetAxis("Mouse Y") * turnSpeed;

        transform.localRotation = Quaternion.Euler(-mouseY, mouseX, 0);

    }
}
