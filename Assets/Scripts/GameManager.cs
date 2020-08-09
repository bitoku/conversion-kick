using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    private int _state = 0; // initial

    public int GetState()
    {
        return _state;
    }

    public void FirstClick()
    {
        _state = 1;
    }

    public void ResetState()
    {
        _state = 0;
    }
}
