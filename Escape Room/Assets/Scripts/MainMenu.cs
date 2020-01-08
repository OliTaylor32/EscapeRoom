using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject camera;
    public GameObject fade;
    public AudioSource background;
    public string function;
    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator OnMouseDown()
    {
        if (function == "Start")
        {
            fade.GetComponent<MeshCollider>().enabled = true;
            fade.GetComponent<Animator>().enabled = true;
            camera.GetComponent<AudioSource>().Play(0);
            background.mute = true;
            yield return new WaitForSeconds(24);
            Application.LoadLevel("EscapeRoom");
        }
        else
        {
            Application.Quit();
        }
    }
}
