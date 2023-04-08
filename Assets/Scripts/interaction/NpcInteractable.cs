using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;

    public void Interact(Transform interactorTransform)
    {
        //add chatbubble https://www.youtube.com/watch?v=K13WnNL1OYM&t=0s

        //add optional animator.SetTrigger("bla");

        //add optional lookat function
    }

    public string GetInteractText()
    {
        return interactText;
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
