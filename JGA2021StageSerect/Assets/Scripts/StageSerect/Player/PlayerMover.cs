using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StageSerect.InputEventer;

namespace StageSerect
{
    namespace Player
    {
        [RequireComponent(typeof (Rigidbody2D))]
        public class PlayerMover : MonoBehaviour
        {
            IInputEventer inputEventer;
            Rigidbody2D rb2d;
            void Start()
            {
                inputEventer = GetComponent<DebugInputer>();
                rb2d = GetComponent<Rigidbody2D>();
            }

            void Update()
            {
                if(Input.GetMouseButtonUp(0))
                {
                    rb2d.velocity = Vector2.zero;
                    rb2d.AddForce(inputEventer.AddForceDirection(1000));
                }
                rb2d.velocity *= 0.98f;
            }
        }
    }
}

