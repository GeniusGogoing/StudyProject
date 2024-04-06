using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDissolveTest : MonoBehaviour
{
    public Transform ball;

    public Material ballMat;

    // Update is called once per frame
    void Update()
    {
        ballMat.SetVector("Vector3_50D778D6",ball.position);
    }
}
