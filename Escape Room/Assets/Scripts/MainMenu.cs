using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject camera;
    public GameObject fade;
    public string function;
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
        if (function == "Start")
        {
            fade.GetComponent<MeshCollider>().enabled = true;
            fade.GetComponent<Animator>().enabled = true;
            camera.GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(24);
            Application.LoadLevel("EscapeRoom");
        }
        else
        {
            Application.Quit();
        }
    }
}
