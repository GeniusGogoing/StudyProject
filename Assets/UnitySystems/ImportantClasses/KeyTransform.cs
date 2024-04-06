using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.PlayerLoop;

public class KeyTransform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        foreach (var system in PlayerLoop.GetCurrentPlayerLoop().subSystemList)
        {
            Debug.Log(system.type.Name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
