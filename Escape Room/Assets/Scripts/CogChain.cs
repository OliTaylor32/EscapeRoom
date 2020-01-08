using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogChain : MonoBehaviour
{
    public GameObject missingCog;
    public bool complete;
    public GameObject cog1;
    public GameObject cog2;
    public GameObject cog3;

    // Start is called before the first frame update
    void Start()
    {
        complete = false;
        gameObject.GetComponent<AudioSource>().mute = true;
    }

    // Update is called once per frame
    void Update()
    {
        cog1.transform.Rotate(0, 20 * Time.deltaTime, 0); 
        if (complete == true) //Only rotate if the player has placed the cog and the cog hasn't been taken off
        {
            cog2.transform.Rotate(0, 20 * Time.deltaTime, 0);
            cog3.transform.Rotate(0, -20 * Time.deltaTime, 0);
        }

        if (missingCog.GetComponent<Cog>().inHands == true) // If it's in the players hands, in can't be in the chain.
        {
            gameObject.GetComponent<AudioSource>().mute = true;
            complete = false;
        }
    }

    public IEnumerator OnMouseDown()
    {
        if (missingCog.GetComponent<Cog>().inHands == true) //If the player has picked up the cog, place the cog.
        {
            missingCog.SendMessage("Place", SendMessageOptions.DontRequireReceiver);
            yield return new WaitForSeconds(1.5f);
            gameObject.GetComponent<AudioSource>().mute = false;
            complete = true;
        }
    }
}
