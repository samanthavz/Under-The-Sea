using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    
    public void StartCutsceneOne()
    {
        //Start animation
        Debug.Log("Start Cutscene 1");
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
}
