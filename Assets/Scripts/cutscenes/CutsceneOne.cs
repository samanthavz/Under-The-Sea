using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneOne : MonoBehaviour
{
    [SerializeField]
    Animator cutsceneOne;

    public void StartCutscene()
    {
        cutsceneOne.SetTrigger("Trigger");
        Debug.Log("Cutscene one started");
    }

}
