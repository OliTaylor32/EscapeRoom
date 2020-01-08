using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject bucket;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (bucket.GetComponent<Bucket>().GetInHands() == true && active == true) //If the waterfall is running and the player has the bucket, fill the bucket
        {
            bucket.GetComponent<Bucket>().FillBucket();
        }

    }
}
