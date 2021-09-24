using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    float x;
    float y;
    public float xSensitivity = 2.0f;
    public float ySensitivity = -2.0f;
    public float yMaximumAngle = 90.0f;
    public float yMinimumAngle = -90.0f;

    void Update()
    {
        Look();
    }

    void Look()
    {
        float inptX = Input.GetAxisRaw("Mouse X");
        float inptY = Input.GetAxisRaw("Mouse Y");
        x += inptX * xSensitivity;
        y += inptY * ySensitivity;
        if (y > yMaximumAngle) y = yMaximumAngle;
        else if (y < yMinimumAngle) y = yMinimumAngle;
        transform.rotation = Quaternion.Euler(y, x, 0.0f);
    }
}
