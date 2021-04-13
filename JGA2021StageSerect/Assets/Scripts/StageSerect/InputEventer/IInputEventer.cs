using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StageSerect
{
    namespace InputEventer
    {
        interface IInputEventer
        {
            Vector2 AddForceDirection(int limitPower);
        }
    }
}