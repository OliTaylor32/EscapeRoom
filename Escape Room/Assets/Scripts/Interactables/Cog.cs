using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cog : MonoBehaviour
{

    public bool inHands;
    public bool placed;
    // Start is called before the first frame update
    void Start()
    {
        inHands = false;
        placed = false;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        inHands = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
    }

    public void Place()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
        gameObject.GetComponent<Animator>().Play("CogPlace");
        placed = true;

    }
}
