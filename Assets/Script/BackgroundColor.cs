using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    public Material dayMat;
    public Material nightMat;
    float timeChecker = 1f;

    public GameObject background;

    public void SwitchBackgroundColor()
    {
        if(timeChecker ==1f)
        {
            background.GetComponent<MeshRenderer>().material = nightMat;
            timeChecker = 0f;
        }
        else if (timeChecker == 0f)
        {
            background.GetComponent<MeshRenderer>().material = dayMat;
            timeChecker = 1f;
        }
        Debug.Log(timeChecker);
    }
    
}
