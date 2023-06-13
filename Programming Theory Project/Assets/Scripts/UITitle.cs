using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UITitle : MonoBehaviour
{
    [SerializeField] private TMP_InputField tmpPlayerName;

    public void StartGame(int id)
    {
        GameManager.Instance.playerName = tmpPlayerName.text;
        SceneManager.LoadScene(id);
    }
}
