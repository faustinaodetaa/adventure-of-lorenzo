using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("tes update");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.volume = 1;
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        //Debug.Log("tes resume");
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.volume = 0;
        //Time.fixedDeltaTime = 0f;
        GameIsPaused = true;
        
        //Debug.Log("tes pause");
    }

    public void LoadMenu()
    {
        //Debug.Log("tes menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/Menu");
    }


}
