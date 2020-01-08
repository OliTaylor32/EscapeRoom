using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPad : MonoBehaviour
{
    public int number;
    public GameObject display1;
    public GameObject display2;
    public GameObject cog;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cog.GetComponent<Cog>().placed == true) //When the cog is placed allow the player to use the numberpad keys
        {
            active = true;
        }
        else
        {
            active = false;
        }
    }

    public void OnMouseDown()
    {
        if (active == true)
        { 
            if (display1.GetComponent<NoDisplay>().inUse == false) //IF the first didgit slot isn't taken up display this number
            {
                display1.GetComponent<NoDisplay>().ButtonPressed(number);
            }
            else //Otherwise display this number in the secound didgit slot.
            {
                display2.GetComponent<NoDisplay>().ButtonPressed(number);
            }
        }
    }

    }
