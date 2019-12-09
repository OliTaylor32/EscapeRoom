using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cog : MonoBehaviour
{

    public bool inHands;
    public Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        inHands = false;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(camera.position, transform.position) > 0.1 && inHands == true)
        {
            Vector3 target = camera.position;
            transform.LookAt(camera);
            transform.position = Vector3.MoveTowards(transform.position, target, (1f * Time.deltaTime));
        }
    }

    public IEnumerator OnMouseDown()
    {
        inHands = true;
        yield return new WaitForSeconds(1.5f);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    public void Place()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<Animator>().Play("CogPlace");
    }
}
