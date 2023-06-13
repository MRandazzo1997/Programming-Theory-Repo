using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIMain : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tmpScore;
    [SerializeField] private TextMeshProUGUI tmpPlayerName;
    [SerializeField] private TextMeshProUGUI tmpGameOver;

    // Start is called before the first frame update
    void Start()
    {
        tmpPlayerName.text = GameManager.Instance.PlayerName;
        tmpScore.text = "Score: 0";
    }

    public void SetScore(int score)
    {
        tmpScore.text = "Score: " + score;
    }

    public void GameOver()
    {
        tmpGameOver.gameObject.SetActive(true);
    }
}
