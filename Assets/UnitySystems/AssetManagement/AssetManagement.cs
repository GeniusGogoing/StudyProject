using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AssetManagement : AssetPostprocessor
{
    private void OnPreprocessAsset()
    {
        Debug.Log("importing asset");
    }
}
