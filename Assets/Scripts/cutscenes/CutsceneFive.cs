using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneFive : MonoBehaviour
{
    void Start()
    {
        GameObject bud = GameObject.Find("Buddy");
        bud.GetComponent<BuddyController>().Buddyspeed2();
    }

    public void StartCutscene()
    {
        Debug.Log("StartCutscene5");
        GetComponent<Subtitles>().StartSubtitles();
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(40f);
        GetComponent<LoadSceneInteract>().Interact(transform);
    }
}
