using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyToxic : MonoBehaviour
{
    public void Toxic()
    {
        StartCoroutine(Counting());
    }

    IEnumerator Counting()
    {
        yield return new WaitForSeconds(15f);
        GetComponent<Subtitles>().StartSubtitles();

        //buddy swim slower
        GameObject bud = GameObject.Find("Buddy");
        bud.GetComponent<BuddyController>().Buddyspeed();

        GameObject exit = GameObject.Find("NextLevelArea");
        exit.GetComponent<Subtitles>().SubtitlesDestroy();

        StartCoroutine(OpenNext());
    }


    IEnumerator OpenNext()
    {
        yield return new WaitForSeconds(19f);

        GameObject obj = GameObject.Find("Objective");
        obj.GetComponent<Objective>().SetObjective("OBJECTIVE: Find the hole to the Dark Waters");

        //enable exit trigger
        GameObject exit = GameObject.Find("NextLevelArea");
        exit.GetComponent<LoadSceneBool>().Open();
        

        
    }
    
}
