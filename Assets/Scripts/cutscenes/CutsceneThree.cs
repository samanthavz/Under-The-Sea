using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneThree : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject playerCamera;

    [SerializeField]
    GameObject buddy;


    public void StartCutsceneThree()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<Animator>().SetTrigger("FadeIn");

        StartCoroutine(CutsceneThreeStart());
    }

    public void ExitCutsceneThree()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<Animator>().SetTrigger("FadeOut");

        GameObject balk = GameObject.Find("CutsceneBalk");
        balk.GetComponent<Animator>().SetTrigger("In");
    }

    IEnumerator CutsceneThreeStart()
    {
        yield return new WaitForSeconds(3f);

        player.SetActive(false);
        playerCamera.SetActive(false);
        buddy.SetActive(false);

        GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<Animator>().SetTrigger("FadeOut");

        GameObject balk = GameObject.Find("CutsceneBalk");
        balk.GetComponent<Animator>().SetTrigger("In");

        GameObject cutscene3 = GameObject.Find("Cutscene3");
        cutscene3.GetComponent<Animator>().SetTrigger("Start");
    }
}
