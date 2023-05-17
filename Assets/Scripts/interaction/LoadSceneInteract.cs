using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneInteract : MonoBehaviour, IInteractable
{

    [SerializeField] private string interactText;

    [SerializeField] Animator canvas;


    //audio stuff

    [SerializeField] AudioSource mainAudio;

    [SerializeField] float duration = 3f;

    [SerializeField] float targetVolume = 0f;

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
        GetComponent<BoxCollider>().enabled = false;
        canvas.SetTrigger("FadeIn");

        //fade out audio

        if (mainAudio != null)
        {
            StartCoroutine(AudioFade.StartFade(mainAudio, duration, targetVolume));
        }
        

        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
