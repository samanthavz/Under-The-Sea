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

        GetComponent<MeshCollider>().enabled = false;

        //enable exit trigger
        GameObject exit = GameObject.Find("NextLevelArea");
        exit.GetComponent<LoadSceneBool>().Open();

        //remove questmark
        GameObject mark = GameObject.Find("questMark");
        mark.SetActive(false);

        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(30f);

        GameObject obj = GameObject.Find("Objective");
        obj.GetComponent<Objective>().SetObjective("OBJECTIVE: Find an exit");

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
