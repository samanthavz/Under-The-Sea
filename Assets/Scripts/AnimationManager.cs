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

    public void CutsceneTwoStart()
    {
        GameObject cutsceneTwo = GameObject.Find("Cutscene2");
        cutsceneTwo.GetComponent<CutsceneTwo>().StartCutscene();
    }

    public void Blackout()
    {
        GameObject canvas = GameObject.Find("MainMenu");
        canvas.GetComponent<MainMenu>().BlackScreen();
    }

    public void SpawnPlayer()
    {
        GameObject cutsceneTwo = GameObject.Find("Cutscene2");
        cutsceneTwo.GetComponent<CutsceneTwo>().EnableCharacters();

    }

    public void TitleScreenAudioStart()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<AudioSource>().Play();
    }

    public void TitleScreenAudioStop()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<AudioSource>().Stop();
    }
}
