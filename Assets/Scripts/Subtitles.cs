using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public struct SubtitleText
{
    public float time;
    public string text;
}


public class Subtitles : MonoBehaviour
{
    [SerializeField]
    GameObject subtitleGO;

    [SerializeField]
    TextMeshProUGUI subtitles;

    public SubtitleText[] subtitleText;

    //private void Start()
    //{
    //    StartSubtitles();
    //}

    public void StartSubtitles()
    {
        StartCoroutine(SubtitleCoroutine());
    }

    IEnumerator SubtitleCoroutine()
    {
        subtitleGO.SetActive(true);
        foreach (var voiceLine in subtitleText)
        {
            subtitles.text = voiceLine.text;

            yield return new WaitForSeconds(voiceLine.time);
        }

        subtitleGO.SetActive(false);
    }

}
