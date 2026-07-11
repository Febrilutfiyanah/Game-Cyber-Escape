using UnityEngine;
using StarterAssets;

public class MobileJoystick : MonoBehaviour
{
    public FixedJoystick joystick;
    public StarterAssetsInputs starterInput;

    [SerializeField]
    private float deadZone = 0.1f;

    void Update()
    {
        if (joystick == null || starterInput == null)
            return;

        float h = joystick.Horizontal;
        float v = joystick.Vertical;

        // Dead Zone agar joystick yang sedikit bergeser tidak membuat player jalan
        if (Mathf.Abs(h) < deadZone)
            h = 0f;

        if (Mathf.Abs(v) < deadZone)
            v = 0f;

        // Selalu kirim input
        starterInput.MoveInput(new Vector2(h, v));
    }
}