using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFall : MonoBehaviour
{
    private bool active;
    public GameObject water;
    public GameObject wheel;
    public GameObject splash;
    public GameObject waves;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        splash.SetActive(false); 
        waves.GetComponent<ParticleSystem>().Stop();
        gameObject.GetComponent<AudioSource>().Pause();
        gameObject.GetComponent<AudioSource>().mute = true;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, -1000 * Time.deltaTime, 0); //Constantly rotate incredibly fast in order to give the illusion of flowing water
        if (active == true)
        {
            //If the switch is pulled, Flow down into the river and spin the waterwheel
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 4, 1), 10 * Time.deltaTime);
            wheel.transform.Rotate(0, 30 * Time.deltaTime, 0);
        }

    }

    public void Activate()
    {
        //Play correct animations for all objects which require the waterfall.
        active = true;
        splash.SetActive(true);
        water.GetComponent<Animator>().Play("WaterRise");
        water.GetComponent<Animator>().Play("WaterStart");
        water.GetComponent<Water>().active = true; //Allow player to Interact with the water (Fill the bucket)
        waves.GetComponent<ParticleSystem>().Play(true);
        gameObject.GetComponent<AudioSource>().UnPause();
        gameObject.GetComponent<AudioSource>().mute = false;

    }
}
