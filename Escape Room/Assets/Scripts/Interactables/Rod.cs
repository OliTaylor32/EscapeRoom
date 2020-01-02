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
        if (collected == false)
        {
            collected = true;
            gameObject.GetComponent<Animator>().Play("RodBuild");
            bucket.GetComponent<Bucket>().BuildRod();
            yield return new WaitForSeconds(3);
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            hook.GetComponent<MeshRenderer>().enabled = false;
        }
    }

}
