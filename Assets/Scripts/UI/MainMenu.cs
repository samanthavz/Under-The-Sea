using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private const float V = 5f;
    [SerializeField]
    Animator animator;

    [SerializeField]
    GameObject blackPanel;


    public void StartCutsceneOne()
    {
        //Start fade out animation
        Cursor.lockState = CursorLockMode.Locked;
        animator.SetBool("Play", true);
    }
        
    // call function after cutscene
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }

    public void BlackScreen()
    {
        blackPanel.SetActive(true);

        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        NextLevel();
    }

}
