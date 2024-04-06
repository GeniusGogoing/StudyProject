using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UGUITest : MonoBehaviour
{
    public RectTransform rt;

    private void Start()
    {
        Camera.main.ScreenToViewportPoint(pos);
        
    }
}
