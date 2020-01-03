using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateExit : MonoBehaviour
{
    public GameObject door;
    public GameObject cog;
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
        if (cog.GetComponent<Cog>().inHands == true)
        {
            gameObject.GetComponent<Animator>().Play("PressureDown");
            cog.GetComponent<Cog>().Drop();
            //Activate Door
        }
    }
}
