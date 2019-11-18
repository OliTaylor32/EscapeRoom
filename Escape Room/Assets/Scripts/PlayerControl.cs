using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    CharacterController charController;
    // Start is called before the first frame update
    void Start()
    {
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

    }
}
