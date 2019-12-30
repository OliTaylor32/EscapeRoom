using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    private bool inHands;
    private bool filled;
    // Start is called before the first frame update
    void Start()
    {
        inHands = false;
        filled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        print("Bucket Clicked");
        inHands = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    public bool GetInHands()
    {
        return inHands;
    }
    
    public void fillBucket()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        //Play Fill animation
        print("Filled Bucket");
        filled = true;
    }
    
    public bool GetFilled()
    {
        return filled;
    }
}
