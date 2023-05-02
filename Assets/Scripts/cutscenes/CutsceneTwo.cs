using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTwo : MonoBehaviour
{
    [SerializeField]
    Animator cutsceneTwo;

    [SerializeField]
    Animator canvasAnimator;

    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject playerCamera;

    [SerializeField]
    GameObject buddy;

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

        GameObject buddyCutscene = GameObject.Find("BuddyCutscene");
        GameObject playerCutscene = GameObject.Find("FishV2");
        buddyCutscene.SetActive(false);
        playerCutscene.SetActive(false);
    }
}
