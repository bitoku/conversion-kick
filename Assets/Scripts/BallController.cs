using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 initialDir = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        float power = Random.Range(10f, 20f);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
