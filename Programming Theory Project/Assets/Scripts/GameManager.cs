using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    // ENCAPSULATION
    [HideInInspector]
    public string PlayerName
    {
        get
        {
            return m_PlayerName;
        }
        set
        {
            if (isGameRunning)
                m_PlayerName = value;
        }
    }

    [HideInInspector]
    public bool isGameRunning = false;

    [HideInInspector]
    public int score = 0;

    private string m_PlayerName = "";

    // Start is called before the first frame update
    void Start()
    {
        isGameRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameRunning && Input.GetKeyDown(KeyCode.Space))
        {
            score = 0;
            isGameRunning = true;
            SceneManager.LoadScene(0);
        }
    }
}
