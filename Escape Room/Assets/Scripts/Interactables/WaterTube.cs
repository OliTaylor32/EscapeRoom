using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTube : MonoBehaviour
{
    public GameObject bucket;
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
        if (bucket.GetComponent<Bucket>().GetInHands() == true && bucket.GetComponent<Bucket>().GetFilled() == true)
        {
            StartCoroutine(Fill());
        }

    }

    private IEnumerator Fill()
    {
        bucket.GetComponentInParent<Animator>().Play("BucketPour");
        bucket.GetComponent<MeshRenderer>().enabled = true;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Animator>().Play("TubeFill");
        yield return new WaitForSeconds(2);
        //Activate Capsule collision.
        yield return new WaitForSeconds(1);
        bucket.GetComponent<MeshRenderer>().enabled = false;
    }
}
