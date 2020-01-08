using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cog : MonoBehaviour
{

    public bool inHands;
    public bool placed;
    public MeshRenderer[] children;
    // Start is called before the first frame update
    void Start()
    {
        inHands = false;
        placed = false;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<Animator>().enabled = true;
        
        children = GetComponentsInChildren<MeshRenderer>();//This is used to get and manage all the childrens mesh renderers so they didn't all have to be assigned and changed individually.
        foreach (MeshRenderer r in children)
            r.enabled = true; //Shows children

    }

    // Update is called once per frame
    void Update()
    {
        if (placed == true)//If it's in the chain, rotate
        {
            transform.Rotate(0, 20 * Time.deltaTime, 0);
        }

    }

    public void OnMouseDown() //Pick up and hide the cog and its children
    {
        inHands = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;

        foreach (MeshRenderer r in children)
            r.enabled = false;
    }

    public IEnumerator Place() //Called by cog chain, show cog and play animation, player no-longer has the cog
    {
        foreach (MeshRenderer r in children)
            r.enabled = true;

        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<Animator>().Play("CogPlace");
        yield return new WaitForSeconds(1.5f);
        gameObject.GetComponent<Animator>().enabled = false;
        placed = true;
        inHands = false;

    }

    public void Drop()//Called by Pressure plate, Shows cog and plays animation, takes cog out of players hands and removes ability for player to interact with it.
    {
        placed = false;
        gameObject.GetComponent<Animator>().enabled = true;
        foreach (MeshRenderer r in children)
            r.enabled = true;

        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<Animator>().Play("CogDrop");
        gameObject.GetComponent<BoxCollider>().enabled = false;
        inHands = false;
    }
}
