using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFall : MonoBehaviour
{
    private bool active;
    public GameObject water;
    public GameObject wheel;
    public GameObject splash;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        splash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, -1000 * Time.deltaTime, 0);
        if (active == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 4, 1), 10 * Time.deltaTime);
            wheel.transform.Rotate(0, 30 * Time.deltaTime, 0);
        }

    }

    public void Activate()
    {
        active = true;
        splash.SetActive(true);
        water.GetComponent<Animator>().Play("WaterRise");
        water.GetComponent<Animator>().Play("WaterStart");
    }
}
