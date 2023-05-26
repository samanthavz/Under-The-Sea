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
        GetComponent<SetActive>().Active();
        GetComponent<SetActive>().Disable();

        //turn off toxic spill
        GameObject toxicx = GameObject.Find("toxicspill");
        toxicx.SetActive(false);

        GetComponent<Subtitles>().StartSubtitles();

        //Start new script
        GameObject buddy = GameObject.Find("Buddy");
        buddy.GetComponent<BuddyToxic>().Toxic();

        Destroy(this);
    }



}
