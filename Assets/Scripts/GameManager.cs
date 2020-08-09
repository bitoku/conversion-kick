using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    public static int TryTimes;
    public static int Score;
    
    // Start is called before the first frame update
    void Awake()
    {
        TryTimes = 1;
        Score = 5;
    }

    private int _state = 0; // initial

    public int GetState()
    {
        return _state;
    }

    public void FirstClick()
    {
        _state = 1;
    }
    
    public void SecondClick()
    {
        _state = 2;
    }

    public void ResetState()
    {
        _state = 0;
    }
}
