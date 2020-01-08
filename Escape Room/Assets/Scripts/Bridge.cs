using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activate()
    {
        gameObject.GetComponent<Animator>().Play("BridgeActivate"); //This animation makes it possible for the player to walk over the bridge
    }
}
