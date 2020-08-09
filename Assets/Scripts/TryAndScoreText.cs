using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TryAndScoreText : MonoBehaviour
{
    [SerializeField] private Text tryAndScoreText;
    private int TryTimes;
    private int Score;

    // Start is called before the first frame update
    void Start()
    {
        TryTimes = GameManager.TryTimes;
        Score = GameManager.Score;
        tryAndScoreText.text = "Try : " + TryTimes + "\nScore : " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
