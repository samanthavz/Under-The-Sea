using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BabyFish : MonoBehaviour, IInteractable
{

    [SerializeField] private string interactText;

    [SerializeField] Animator babyFish;

    [SerializeField] GameObject momFish;


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

        //switch out the subtitles for mom fish
        momFish.GetComponent<NpcInteractable>();

    }



}