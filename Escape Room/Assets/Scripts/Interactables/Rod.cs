using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod : MonoBehaviour
{
    public bool collected;
    public GameObject bucket;
    public GameObject hook;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator OnMouseDown()
    {
        if (collected == false) //If the rod hasn't yet been picked up
        {
            collected = true;
            gameObject.GetComponent<Animator>().Play("RodBuild");
            bucket.GetComponent<Bucket>().BuildRod();
            yield return new WaitForSeconds(3);
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            hook.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public void Place()//Called by the pressure plate, Plays the corresponding animation
    {
        gameObject.GetComponent<Animator>().Play("RodPlace");
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        hook.GetComponent<MeshRenderer>().enabled = true;
        StartCoroutine(PlaceEnd());
    }

    private IEnumerator PlaceEnd() //Hides Rod once the animation is complete
    {
        yield return new WaitForSeconds(2.5f);
        gameObject.GetComponent<Animator>().Play("RodIdle");
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        hook.GetComponent<MeshRenderer>().enabled = false;
    }

}
