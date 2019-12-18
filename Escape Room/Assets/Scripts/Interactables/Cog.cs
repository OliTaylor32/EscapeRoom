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

        children = GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer r in children)
            r.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (placed == true)
        {
            transform.Rotate(0, 20 * Time.deltaTime, 0);
        }

    }

    public void OnMouseDown()
    {
        inHands = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;

        foreach (MeshRenderer r in children)
            r.enabled = false;
    }

    public IEnumerator Place()
    {
        foreach (MeshRenderer r in children)
            r.enabled = true;

        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<Animator>().Play("CogPlace");
        yield return new WaitForSeconds(1.5f);
        gameObject.GetComponent<Animator>().enabled = false;
        placed = true;

    }
}
