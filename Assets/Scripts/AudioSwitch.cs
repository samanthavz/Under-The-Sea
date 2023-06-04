using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwitch : MonoBehaviour
{
    public AudioClip defaultAmbience;
    public AudioClip newTrack;

    private AudioSource track01;
    private AudioSource track02;
    private bool isPlayingTrack01;

    public static AudioSwitch instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        track01 = gameObject.AddComponent<AudioSource>();
        track02 = gameObject.AddComponent<AudioSource>();
        isPlayingTrack01 = true;

        track01.clip = defaultAmbience;
        track01.Play();
        track01.loop = true;
    }

    public void SwapTrack(AudioClip newClip)
    {
        StopAllCoroutines();

        StartCoroutine(FadeTrack(newClip));
    }

    public void TriggerSwap()
    {
        SwapTrack(newTrack);
    }

    private IEnumerator FadeTrack(AudioClip newClip)
    {
        float timeToFade = 5f;
        float timeElapsed = 0;


        if (isPlayingTrack01)
        {
            track02.clip = newClip;
            

            while(timeElapsed < timeToFade)
            {
                track01.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
                yield return null;
            }

            StartCoroutine(FadeTrack2());
            track01.Stop();
        }
    }

    private IEnumerator FadeTrack2()
    {
        float timeToFade = 4f;
        float timeElapsed = 0;

        track02.Play();
        while (timeElapsed < timeToFade)
        {
            track02.volume = Mathf.Lerp(0, 0.5f, timeElapsed / timeToFade);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }

    public void AudioStop()
    {
        track02.Stop();
    }
}
