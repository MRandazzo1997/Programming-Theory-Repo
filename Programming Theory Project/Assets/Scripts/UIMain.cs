using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIMain : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tmpPlayerName;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance != null)
            tmpPlayerName.text = GameManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
