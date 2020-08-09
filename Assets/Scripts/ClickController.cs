using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    private GameManager _gameManager;
    private BallController _ballController;

    private Vector2 dragStart;
    private Vector3 position;

    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _ballController = FindObjectOfType<BallController>();
    }
    
    void Update()
    {
        if (_gameManager.GetState() == 0 && Input.GetMouseButtonUp(0))
        {
            // determine position
            Debug.Log("up");
            _gameManager.FirstClick();
            position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _ballController.transform.position.z);
        }
        else if (_gameManager.GetState() == 1 && Input.GetMouseButtonDown(0))
        {
            dragStart
        }
        else if (_gameManager.GetState() == 1 && Input.GetMouseButtonUp(0))
        {
            // determine force
            Debug.Log("drag");
            _gameManager.ResetState();
            force2 = ;
            _ballController.HitBall(force, position);
        } 
    }

    public void OnMouseDrag()
    {
        throw new NotImplementedException();
    }
}
