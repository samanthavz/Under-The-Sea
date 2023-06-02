using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OilFish : MonoBehaviour, IInteractable
{

    [SerializeField] private string interactText;


    public string GetInteractText()
    {
        return interactText;
    }

    public Transform GetTransform()
    {
        return transform;
    }

    public void Interact(Transform interactorTransform)
    {

        //turn off collider
        GetComponent<SphereCollider>().enabled = false;

        GetComponent<Subtitles>().StartSubtitles();

        GameObject obj = GameObject.Find("Objective");
        obj.GetComponent<Objective>().SetObjective("OBJECTIVE: Listen to Big Fish");

        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(54f);

        GameObject obj = GameObject.Find("Objective");
        obj.GetComponent<Objective>().SetObjective("OBJECTIVE: Look around the area");

        StartCoroutine(Timer2());
    }

    IEnumerator Timer2()
    {
        yield return new WaitForSeconds(40f);

        //startcutscene5
        GameObject cs5 = GameObject.Find("Cutscene5");
        cs5.GetComponent<CutsceneFive>().StartCutscene();

        Destroy(this);
    }



}
