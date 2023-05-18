using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuddyMom : MonoBehaviour, IInteractable
{

    [SerializeField] private string interactText;

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
        //activate subtitles
        GetComponent<Subtitles>().StartSubtitles();

        //enable exit trigger
        GameObject exit = GameObject.Find("NextLevelArea");
        exit.GetComponent<LoadSceneBool>().Open();
        Destroy(this);
    }

    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) < 10f)
        {
            int speed = 5;
            var targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);

            // Smoothly rotate towards the target point.
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        }
    }


}
