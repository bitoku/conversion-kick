using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 initialDir = new Vector3(Random.Range(-1f, 1f), Random.Range(0f, 1f), 3).normalized;
        float power = Random.Range(3000f, 5000f);
    }

    public void HitBall(Vector3 position, Vector3 force)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForceAtPosition(force, position);
    }
}
