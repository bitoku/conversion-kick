using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TryButton : MonoBehaviour
{
    [SerializeField] private GameObject RugbyBall;
    [SerializeField] private Text tryAndScoreText;
    private int TryTimes;
    private int Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        RugbyBall.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        RugbyBall.transform.position = new Vector3(0, 1, 25);
        RugbyBall.transform.rotation = Quaternion.Euler(0, 0, 90);
        GameManager.TryTimes += 1;
        GameManager.Score += 5;
        TryTimes = GameManager.TryTimes;
        Score = GameManager.Score;
        tryAndScoreText.text = "Try : " + TryTimes + "\nScore : " + Score;
    }
}
