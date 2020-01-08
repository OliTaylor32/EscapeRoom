using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    private bool inHands;
    private bool filled;
    public GameObject handle;
    // Start is called before the first frame update
    void Start()
    {
        inHands = false;
        filled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        handle.GetComponent<MeshRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown() //Collect the bucket
    {
        print("Bucket Clicked");
        inHands = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        handle.GetComponent<MeshRenderer>().enabled = false;
    }

    public bool GetInHands() //Getter
    {
        return inHands;
    }
    
    public void FillBucket() //Called by water, plays animation
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        handle.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponentInParent<Animator>().Play("BucketFill");
        print("Filled Bucket");
        StartCoroutine(FillComplete());
    }

    public IEnumerator FillComplete() //Fills and hides the bucket once animation is played
    {
        yield return new WaitForSeconds(3);
        filled = true;
        gameObject.GetComponentInParent<Animator>().Play("BucketIdle");
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        handle.GetComponent<MeshRenderer>().enabled = false;
    }
    
    public bool GetFilled() //Getter
    {
        return filled;
    }
    
    public void BuildRod() //Called by Rod, Plays animation
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        handle.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponentInParent<Animator>().Play("BucketBuild");
        StartCoroutine(BuildEnd());
    }

    private IEnumerator BuildEnd() // Hides bucket once animation is complete
    {
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        handle.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponentInParent<Animator>().Play("BucketIdle");
    }

    public void Place() //Places the bucket on the pressure pad, disables the ability to interact with the bucket
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        handle.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponentInParent<Animator>().Play("BucketPlace");
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

}
