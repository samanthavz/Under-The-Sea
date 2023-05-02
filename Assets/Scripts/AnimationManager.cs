using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    //this script is used for animation events to call functions on different gameobjects.

    public void CutsceneOneStart()
    {
        GameObject cutsceneOne = GameObject.Find("Cutscene1");
        cutsceneOne.GetComponent<CutsceneOne>().StartCutscene();
    }

    public void Blackout()
    {
        GameObject canvas = GameObject.Find("MainMenu");
        canvas.GetComponent<MainMenu>().BlackScreen();
    }

    public void Test()
    {
        Debug.Log("test");
       
    }
}
