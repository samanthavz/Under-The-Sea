using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CutsceneTwo : MonoBehaviour
{
    [SerializeField]
    Animator cutsceneTwo;

    [SerializeField]
    Animator canvasAnimator;

    [SerializeField]
    Animator cutsceneBalk;

    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject playerCamera;

    [SerializeField]
    GameObject buddy;

    [SerializeField]
    CinemachineFreeLook FreeLook;


    // Start is called before the first frame update
    void Start()
    {

        player.SetActive(false);
        playerCamera.SetActive(false);
        buddy.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
    }

    public void StartCutscene()
    {
        cutsceneTwo.SetTrigger("Trigger");
        Debug.Log("Cutscene two started");
    }

    public void StartFade()
    {
        canvasAnimator.SetTrigger("Fade");
    }

    public void EnableCharacters()
    {
        player.SetActive(true);
        playerCamera.SetActive(true);
        buddy.SetActive(true);
        
        FreeLook.m_RecenterToTargetHeading.RecenterNow();
       
        StartCoroutine(CutsceneBalk());

        GameObject buddyCutscene = GameObject.Find("BuddyCutscene");
        GameObject playerCutscene = GameObject.Find("FishV2");
        buddyCutscene.SetActive(false);
        playerCutscene.SetActive(false);
    }

    IEnumerator CutsceneBalk()
    {
        yield return new WaitForSeconds(4);
        cutsceneBalk.SetTrigger("Out");
        FreeLook.m_RecenterToTargetHeading.m_WaitTime = 999999999999f;

        GameObject obj = GameObject.Find("Objective");
        obj.GetComponent<Objective>().SetObjective("OBJECTIVE: Find an exit");
    }

}
