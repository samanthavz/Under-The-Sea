using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BabyFish : MonoBehaviour, IInteractable
{

    [SerializeField] private string interactText;

    [SerializeField] Animator babyFish;

    [SerializeField] GameObject momFish;

    [SerializeField] Transform player;


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
        babyFish.SetTrigger("Trigger");

        GameObject obj = GameObject.Find("Objective");
        obj.GetComponent<Objective>().SetObjective("OBJECTIVE: Look around or find the cave");

        GameObject exit = GameObject.Find("NextLevelArea");
        exit.GetComponent<LoadSceneBool>().Open();

        GameObject buddy = GameObject.Find("Buddy");
        buddy.GetComponent<Subtitles>().StartSubtitles();


        //switch out the subtitles for mom fish
        momFish.GetComponent<FishMom>().text = "Fish Mom: Thank you so much for finding my son!";
        Destroy(this);
    }


}
