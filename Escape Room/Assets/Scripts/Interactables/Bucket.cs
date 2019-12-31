﻿using System.Collections;
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
    
    public void FillBucket()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponentInParent<Animator>().Play("BucketFill");
        print("Filled Bucket");
        StartCoroutine(FillComplete());
    }

    public IEnumerator FillComplete()
    {
        yield return new WaitForSeconds(3);
        filled = true;
        gameObject.GetComponentInParent<Animator>().Play("BucketIdle");
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
    
    public bool GetFilled()
    {
        return filled;
    }
}
