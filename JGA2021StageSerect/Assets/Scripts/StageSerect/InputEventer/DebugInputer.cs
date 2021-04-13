using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StageSerect
{
    namespace InputEventer
    {
        public class DebugInputer : MonoBehaviour, IInputEventer
        {
            Vector2 downPos;
            Vector2 upPos;
            public Vector2 AddForceDirection(int limiPower)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    downPos = Input.mousePosition;
                    upPos = Vector2.zero;
                }
                if (Input.GetMouseButtonUp(0))
                {
                    upPos = Input.mousePosition;
                }
                
                return upPos == Vector2.zero ? Vector2.zero : Vec2MaxRange(downPos - upPos, limiPower);
            }

            private Vector2 Vec2MaxRange(Vector2 generalVec2,int limitNum)
            {
                Vector2 resultPos = generalVec2;
                if (resultPos.x > limitNum) resultPos.x = limitNum;
                if (resultPos.x < -limitNum) resultPos.x = -limitNum;
                if (resultPos.y > limitNum) resultPos.y = limitNum;
                if (resultPos.y < -limitNum) resultPos.y = -limitNum;
                return resultPos;
            }
        }

    }
}
