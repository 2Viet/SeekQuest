using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{

    public delegate void StateGS();
    public static StateGS Pause;
    public static StateGS Resume;


    private bool paused;

    [SerializeField] private GameObject m_pauseMenu;

    void Awake()
    {
        Pause += PauseGame;
        Resume += ResumeGame;
    }

    void Start()
    {
        paused = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(paused)
        {
            m_pauseMenu.SetActive(true);
        }
        else 
        {
            m_pauseMenu.SetActive(false);
        }
    }

    public bool Status(bool value)
    {
        paused = value;
        return paused;
    }

    public void PauseGame()
    {
        Status(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Status(false);
        Time.timeScale = 1;
    }

    public void ToggleHelpMenu()
    {
        HelpMEnu.toggleOn?.Invoke();
    }


}
