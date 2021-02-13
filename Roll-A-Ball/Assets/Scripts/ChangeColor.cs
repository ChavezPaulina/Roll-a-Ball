using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Camera cam;
    public Dropdown myDropdown;
    public GameObject Player;

    Color Red = new Color(255, 0, 0);
    Color Green = new Color(0, 255, 0);
    Color Blue = new Color(0, 0, 255);
    public static Color Ballc;
    void Update()
    {
        switch(myDropdown.value)
        {
            default:
                Ballc = Red;
                break;
            case 1:
                Ballc = Red;
                break;
            case 2:
                Debug.Log("this is blue");
                Ballc = Blue;

                break;
            case 3:
                Ballc = Green;
                break;
        }

    }
}
