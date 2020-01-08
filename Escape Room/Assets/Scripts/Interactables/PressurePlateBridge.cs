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

    public IEnumerator OnMouseDown()
    {
        if (rod.GetComponent<Rod>().collected == true) //If the rod has been collected, play animation and activate the bridge
        {

            rod.GetComponent<Rod>().Place();
            bucket.GetComponent<Bucket>().Place();
            yield return new WaitForSeconds(1.5f);
            gameObject.GetComponent<Animator>().Play("PressureDown");

            bridge.GetComponent<Bridge>().Activate();
        }
    }
}
