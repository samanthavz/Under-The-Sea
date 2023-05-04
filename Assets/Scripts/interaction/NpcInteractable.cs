using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteractable : MonoBehaviour, IInteractable
{
    public Transform player;

    [SerializeField] private string interactText;

    [TextArea(15,20)]
    public string text;

    public void Interact(Transform interactorTransform)
    {
        ChatBubble.Create(transform.transform, new Vector3(1.5f, 1.7f, 0f), text);

        //add optional animator.SetTrigger("bla");

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
            int speed = 5;
            var targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
     
            // Smoothly rotate towards the target point.
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        }
    }
}
