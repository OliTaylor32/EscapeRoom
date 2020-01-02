using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateBridge : MonoBehaviour
{
    public GameObject rod;
    public GameObject bucket;
    public GameObject bridge;
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
        if (rod.GetComponent<Rod>().collected == true)
        {
            gameObject.GetComponent<Animator>().Play("PressureDown");
            //Play animation for Rod
            //Play animation for bucket

            bridge.GetComponent<Bridge>().Activate();
        }
    }
}
