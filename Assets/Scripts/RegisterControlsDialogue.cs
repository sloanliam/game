using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers;

public class RegisterControlsDialogue : MonoBehaviour
{
    protected static bool isRegistered = false;
    private bool didIRegister = false;
    private PlayerActionControls controls;
    void Awake()
    {
        controls = new PlayerActionControls();
    }
    void OnEnable()
    {
        if (!isRegistered)
        {
            isRegistered = true;
            didIRegister = true;
            controls.Enable();
            controls.Enable();
            PixelCrushers.InputDeviceManager.RegisterInputAction("MoveVertical", controls.Land.MoveVertical);
        }
    }
    void OnDisable()
    {
        if (didIRegister)
        {
            isRegistered = false;
            didIRegister = false;
            controls.Disable();
        }
    }
}
