using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private bool unlocked;

    // Start is called before the first frame update
    void Start()
    {
        unlocked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KeyObtained()
    {
        unlocked = true;
    }

    public void OnMouseDown()
    {
        if (unlocked == true)
        {
            gameObject.GetComponent<Animator>().Play("RodBoxOpen");
        }
    }
}
