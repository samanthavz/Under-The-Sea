using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneOne : MonoBehaviour
{
    [SerializeField]
    Animator cutsceneOne;

    [SerializeField]
    Animator cutsceneBalk;

    public void StartCutscene()
    {
        cutsceneOne.SetTrigger("Trigger");
        cutsceneBalk.SetTrigger("In");
        Debug.Log("Cutscene one started");
    }

}
