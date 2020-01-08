using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public BoxCollider boxCollision;
    private bool unlocked;

    // Start is called before the first frame update
    void Start()
    {
        unlocked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KeyObtained() //Called by the water tube, when filled the box can be opened.
    {
        unlocked = true;
    }

    public void OnMouseDown()
    {
        if (unlocked == true) //When the tube is filled, allow the opening animation to be played, this will allow the player to collect the rod inside.
        {
            gameObject.GetComponent<Animator>().Play("RodBoxOpen");
            gameObject.GetComponent<BoxCollider>().enabled = false;
            boxCollision.enabled = false;
        }
    }
}
