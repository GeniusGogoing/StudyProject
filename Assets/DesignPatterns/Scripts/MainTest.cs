using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTest : MonoBehaviour
{
    public class A : IEnumerable
    {
        private List<int> _data;

        public A(List<int> data)
        {
            _data = data;
        }
        
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class AIterator : IEnumerator
    {
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current { get; }
    }
}
