using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSwitch : MonoBehaviour
{
    private bool active;
    public GameObject waterFall;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        print("Clicked");
        gameObject.GetComponent<Animator>().Play("StringSwitchPull");

        if (active == false)
        {
            GetComponent<AudioSource>().Play(0);
            active = true;
            waterFall.GetComponent<WaterFall>().Activate();
        }
        gameObject.GetComponent<Animator>().Play("StringSwitchIdle");

    }
}
