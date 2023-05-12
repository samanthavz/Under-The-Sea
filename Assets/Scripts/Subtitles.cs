using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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

    public void StartSubtitles()
    {

        StartCoroutine(SubtitleCoroutine());
    }

    IEnumerator SubtitleCoroutine()
    {
        subtitleGO.SetActive(true);
        foreach (var voiceLine in subtitleText)
        {
            subtitleGO.SetActive(true);
            subtitles.text = voiceLine.text;
            subtitleGO.GetComponent<AudioSource>().Play();
            
            if (subtitles.text != "")
            {
                GameObject subtitleArea = GameObject.Find("SubtitleArea");
                subtitleArea.GetComponent<Image>().enabled = true;
            } else
            {
                GameObject subtitleArea = GameObject.Find("SubtitleArea");
                subtitleArea.GetComponent<Image>().enabled = false;
            }


            yield return new WaitForSeconds(voiceLine.time);
        }

        subtitleGO.SetActive(false);
    }

}
