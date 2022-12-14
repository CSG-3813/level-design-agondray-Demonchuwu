using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static GameObject Instance;
    public GameObject SettingsMenu;
    public GameObject CreditsPanel;

    void Awake()
    {
        if (Instance != null)
            Destroy(Instance);

        Instance = gameObject;
        DontDestroyOnLoad(this);

    }
    private void Start()
    {
        SettingsMenu.SetActive(false);
        CreditsPanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
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
        SettingsMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void MainMenu()
    {
        SettingsMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_Menu");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void CloseButton()
    {
        SettingsMenu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Pause()
    {
        SettingsMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game...");
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
    }

    public void CreditOpen()
    {
        CreditsPanel.SetActive(true);
    }
    public void CreditClose()
    {
        CreditsPanel.SetActive(false);
    }
}
