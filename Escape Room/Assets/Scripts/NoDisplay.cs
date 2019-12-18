using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDisplay : MonoBehaviour
{
    private int value;
    public int display;
    public GameObject otherDisplay;
    public GameObject door;
    public bool inUse;

    // Start is called before the first frame update
    void Start()
    {
        inUse = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (display == 2)
        {
            if (inUse == true && otherDisplay.GetComponent<NoDisplay>().inUse == true)
            {
                if (value == 7 && otherDisplay.GetComponent<NoDisplay>().value == 1)
                {
                    Destroy(door);
                }
                else
                {
                    otherDisplay.GetComponent<NoDisplay>().Reset();
                    Reset();
                }
            }
        }
    }

    public void ButtonPressed(int number)
    {
        switch (number)
        {
            case 0:
                gameObject.GetComponent<Animator>().Play("NoReset0");
                value = 0;
                break;
            case 1:
                gameObject.GetComponent<Animator>().Play("No1");
                value = 1;
                break;
            case 2:
                gameObject.GetComponent<Animator>().Play("No2");
                value = 2;
                break;
            case 3:
                gameObject.GetComponent<Animator>().Play("No3");
                value = 3;
                break;
            case 4:
                gameObject.GetComponent<Animator>().Play("No4");
                value = 4;
                break;
            case 5:
                gameObject.GetComponent<Animator>().Play("No5");
                value = 5;
                break;
            case 6:
                gameObject.GetComponent<Animator>().Play("No6");
                value = 6;
                break;
            case 7:
                gameObject.GetComponent<Animator>().Play("No7");
                value = 7;
                break;
            case 8:
                gameObject.GetComponent<Animator>().Play("No8");
                value = 8;
                break;
            case 9:
                gameObject.GetComponent<Animator>().Play("No9");
                value = 9;
                break;

            default:
                break;
        }
        inUse = true;

    }

    public void Reset()
    {
        gameObject.GetComponent<Animator>().StopPlayback();
        gameObject.GetComponent<Animator>().Play("NoReset0");
        value = 0;
        inUse = false;
    }
}
