using System;
using UnityEngine;

namespace CSharpStudy.Scripts
{
    struct MyStruct
    {
        private int a;

        public MyStruct(int value)
        {
            a = value;
        }

        public void StructCall()
        {
            Debug.Log($"a = {a}");
        }
    }
    
    public class CSharpMain : MonoBehaviour
    {
        // 值类型
        private byte b;
        private bool bo;
        private short s;
        private int i;
        private long l;
        private float f;
        private double d;
        private MyStruct _myStruct = new MyStruct(3);

        void PrintTypeInfo()
        {
            Debug.Log($"byte: {i.GetType()} min: {int.MinValue} max: {int.MaxValue}");
        }
        
        private void Start()
        {
            PrintTypeInfo();
            _myStruct.StructCall();
        }
    }
}
