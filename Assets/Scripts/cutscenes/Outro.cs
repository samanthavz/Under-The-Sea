using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Outro : MonoBehaviour
{
    [SerializeField] AudioSource mainAudio;

    [SerializeField] float duration = 3f;

    [SerializeField] float targetVolume = 0f;
    public void Restart()
    {
        StartCoroutine(AudioFade.StartFade(mainAudio, duration, targetVolume));
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Intro");
    }
}

