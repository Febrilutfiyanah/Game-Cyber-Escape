using UnityEngine;
using StarterAssets;

public class MobileJoystick : MonoBehaviour
{
    public FixedJoystick joystick;
    public StarterAssetsInputs starterInput;

    void Update()
    {
        if (joystick == null || starterInput == null)
            return;

        float h = joystick.Horizontal;
        float v = joystick.Vertical;

        // Hanya kirim input jika joystick digerakkan
        if (Mathf.Abs(h) > 0.05f || Mathf.Abs(v) > 0.05f)
        {
            starterInput.MoveInput(new Vector2(h, v));
        }
    }
}