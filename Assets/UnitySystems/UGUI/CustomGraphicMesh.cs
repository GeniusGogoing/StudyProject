using System.Collections;
using System.Collections.Generic;
using ProxyPatternExample1;
using UnityEngine;
using UnityEngine.UI;

public class CustomGraphicMesh : MaskableGraphic
{
    public int vertexAmount = 10;
    private float radius = 100;
    
    protected override void OnPopulateMesh(VertexHelper vh)
    {
        base.OnPopulateMesh(vh);
        vh.Clear();
        PupulateCircle(vh);
    }

    void PupulateCircle(VertexHelper vh)
    {
        int index = 0;
        float unitRadian = 2 * Mathf.PI / (vertexAmount);
        vh.AddVert(Vector3.zero,color,Vector2.zero);
        while (index <= vertexAmount)
        {
            vh.AddVert(new Vector3(radius*Mathf.Sin(unitRadian*index),radius*Mathf.Cos(unitRadian*index),0),color,Vector2.zero);
            index++;
        }

        index = 0;
        while (index <= vertexAmount-1)
        {
            vh.AddTriangle(0,index+1,index+2);
            index++;
        }
    }
}
