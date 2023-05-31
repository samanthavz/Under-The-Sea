using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChapterScript : MonoBehaviour
{
    [SerializeField] int seconds;
    [SerializeField] TextMeshProUGUI tmpro;
    [SerializeField] string textToWrite;

    GameObject chapterText;


    // Start is called before the first frame update
    void Start()
    {
        chapterText = GameObject.Find("ChapterText");
        StartCoroutine(Timer());
        tmpro.text = textToWrite;
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(seconds);
        chapterText.GetComponent<Animator>().SetTrigger("Fade"); 
    }

    public void DisableText()
    {
       chapterText.SetActive(false);
    }

}
