using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneBool : MonoBehaviour, IInteractable
{

    [SerializeField] private string interactText;

    [SerializeField] Animator canvas;

    public bool enter = false;


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
        if (enter)
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
        else
        {
            GetComponent<Subtitles>().StartSubtitles();
        }
        
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Open()
    {
        enter = true;
        Debug.Log("Exit opened");
    }


}
