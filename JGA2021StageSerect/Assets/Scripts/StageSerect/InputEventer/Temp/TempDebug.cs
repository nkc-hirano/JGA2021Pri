using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StageSerect
{
    namespace InputEventer
    {
        public class TempDebug : MonoBehaviour
        {
            IInputEventer inputEventer;
            // Start is called before the first frame update
            void Start()
            {
                inputEventer = GetComponent<DebugInputer>();
            }

            // Update is called once per frame
            void Update()
            {
                Debug.Log(inputEventer.AddForceDirection(1000));
            }
        }
    }
}

