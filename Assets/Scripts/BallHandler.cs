using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallHandler : MonoBehaviour
{
    private void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed) { return; }

        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();

        print (touchPosition);
    }
}
