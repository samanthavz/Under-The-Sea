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

    [SerializeField]
    GameObject mainCamera;

    [SerializeField]
    GameObject plastic;


    public void StartCutsceneThree()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<Animator>().SetTrigger("FadeIn");

        StartCoroutine(CutsceneThreeStart());
    }

    public void ExitCutsceneThree()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<Animator>().SetTrigger("FadeIn");


        StartCoroutine(ExitAnimation());
    }

    IEnumerator CutsceneThreeStart()
    {
        yield return new WaitForSeconds(3f);

        player.SetActive(false);
        playerCamera.SetActive(false);
        buddy.SetActive(false);

        //set camera position
        mainCamera.transform.SetPositionAndRotation(new Vector3(-17.37f, 43.55f, 77.41f), Quaternion.Euler(6.486f, -63.78f, 4.975f));

        GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<Animator>().SetTrigger("FadeOut2");
        canvas.GetComponent<Subtitles>().SubtitlesDestroy();

        GameObject balk = GameObject.Find("CutsceneBalk");
        balk.GetComponent<Animator>().SetTrigger("In");

        StartCoroutine(CutsceneThreeAnimator());
    }

    IEnumerator CutsceneThreeAnimator()
    {
        yield return new WaitForSeconds(3f);

        GameObject cutscene3 = GameObject.Find("Cutscene3");
        cutscene3.GetComponent<Animator>().SetTrigger("Start");
    }

    IEnumerator ExitAnimation()
    {
        yield return new WaitForSeconds(2f);

        player.SetActive(true);
        playerCamera.SetActive(true);
        buddy.SetActive(true);

        GameObject barrier = GameObject.Find("CutsceneBarrier");
        barrier.SetActive(false);

        //plastic around buddy
        plastic.SetActive(true);

        GameObject canvas = GameObject.Find("Canvas");
        canvas.GetComponent<Animator>().SetTrigger("FadeOut3");

        GameObject obj = GameObject.Find("Objective");
        obj.GetComponent<Objective>().SetObjective("OBJECTIVE: Look around or find the way to the Open Sea");
    }

    public void CutsceneBalkUp()
    {
        GameObject balk = GameObject.Find("CutsceneBalk");
        balk.GetComponent<Animator>().SetTrigger("Out");
    }
}
