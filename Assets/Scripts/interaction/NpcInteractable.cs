using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteractable : MonoBehaviour, IInteractable
{
    public Transform player;

    [SerializeField] private string interactText;

    public void Interact(Transform interactorTransform)
    {
        ChatBubble.Create(transform.transform, new Vector3(-.3f, 1.7f, 0f), "Blub Blub!");

        //add optional animator.SetTrigger("bla");

        //add optional lookat function
        // transform.LookAt(player);
    }

    public string GetInteractText()
    {
        return interactText;
    }

    public Transform GetTransform()
    {
        return transform;
    }

    void Update()
    {
        if(Vector3.Distance(player.position,transform.position) < 10f)
        {
        transform.LookAt(player);
        }
    }
}
