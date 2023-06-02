using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour
{
    bool pressed = false;
    [SerializeField]
    GameObject escapeMenu;

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pressed)
            {
                pressed = true;
                escapeMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
            }
            else if (pressed)
            {
                escapeMenu.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                pressed = false;
            }


        }
    }
}
