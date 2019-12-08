using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogChain : MonoBehaviour
{
    public GameObject cog;
    public bool complete;
    // Start is called before the first frame update
    void Start()
    {
        complete = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (cog.GetComponent<Cog>().inHands == true)
        {
            complete = true;
        }
    }
}
