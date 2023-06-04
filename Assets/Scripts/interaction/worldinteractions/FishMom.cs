using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMom : MonoBehaviour, IInteractable
{
    public Transform player;

    [SerializeField] private string interactText;

    [TextArea(15,20)]
    public string text;

    public void Interact(Transform interactorTransform)
    {
        GameObject fish = GameObject.Find("TropicalFish");
        fish.GetComponent<AudioSource>().Play();
        ChatBubble.Create(transform.transform, new Vector3(1.5f, 1.7f, 0f), text);

        if (text != "Fish Mom: Thank you so much for finding my son!")
        {
            GameObject obj = GameObject.Find("Objective");
            obj.GetComponent<Objective>().SetObjective("OBJECTIVE: Look for the baby fish");
        }

        //remove questmark
        GameObject mark = GameObject.Find("questMark");
        mark.SetActive(false);


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
