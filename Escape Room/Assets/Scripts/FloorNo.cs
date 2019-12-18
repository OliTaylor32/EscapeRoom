using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorNo : MonoBehaviour
{
    public GameObject cog;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cog.GetComponent<Cog>().placed == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
