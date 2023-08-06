using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem.Switch;

namespace DartCore.Utilities
{
    public static class InputUtilities
    {
        public static bool IsUsingGamepad() => GetCurrentGamepad() != null;
        public static Gamepad GetCurrentGamepad() => Gamepad.all.Count > 0 ? Gamepad.all[0] : null;

        public static GamepadPlatform GetGamepadPlatform()
        {
            if (!IsUsingGamepad()) return GamepadPlatform.None;

            var gamepad = GetCurrentGamepad();
            Debug.Log(Gamepad.all.Aggregate("", (current, g) => current + (g.name + " | ")));

            return gamepad switch
            {
                DualShockGamepad => GamepadPlatform.Playstation,
                SwitchProControllerHID => GamepadPlatform.Nintendo,
                _ => GamepadPlatform.Xbox
            };
        }
    }

    public enum GamepadPlatform
    {
        None = 0,
        Xbox = 1,
        Playstation = 2,
        Nintendo = 3,
    }

    public enum GamepadKey
    {
        RightTrigger = 0,
        LeftTrigger = 15,
        RightBumper = 1,
        LeftBumper = 16,
        LeftStick = 2,
        LeftStickButton = 3,
        RightStick = 4,
        RightStickButton = 5,
        Dpad = 6,
        DpadTop = 7,
        DpadBottom = 8,
        DpadRight = 9,
        DpadLeft = 10,
        TopButton = 11,
        BottomButton = 12,
        LeftButton = 13,
        RightButton = 14
    }
}
