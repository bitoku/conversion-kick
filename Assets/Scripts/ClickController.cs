using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    private GameManager _gameManager;
    private BallController _ballController;
    private Camera _mainCamera;

    private Vector3 _position;
    private Vector2 _power;

    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _ballController = FindObjectOfType<BallController>();
        _mainCamera = Camera.main;
    }
    
    void Update()
    {
        if (_gameManager.GetState() == 1)
        {
            _power = Input.mousePosition - _position;
            // Debug.Log(_power);
        }
        if (_gameManager.GetState() == 0 && Input.GetMouseButtonDown(0))
        {
            // determine position
            Debug.Log(Input.mousePosition);
            _gameManager.FirstClick();
            _position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _ballController.transform.position.z);
        }
        else if (_gameManager.GetState() == 1 && Input.GetMouseButtonUp(0))
        {
            // determine force
            Debug.Log("drag");
            _gameManager.ResetState();
            Vector3 force = new Vector3(-_power.x, -_power.y, 1000f);
            Vector3 worldPos = _mainCamera.ScreenToWorldPoint(_position);
            _ballController.HitBall(worldPos, force);
            Debug.Log(force);
            Debug.Log(worldPos);
        } 
    }

    public void OnMouseDrag()
    {
        throw new NotImplementedException();
    }
}
