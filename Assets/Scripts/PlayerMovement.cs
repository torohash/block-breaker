using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    private void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;

        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
            horizontal = -1f;
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
            horizontal = 1f;
        if (Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed)
            vertical = -1f;
        if (Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed)
            vertical = 1f;

        Vector3 movement = new Vector3(horizontal, vertical, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        WrapAroundScreen();
    }

    private void WrapAroundScreen()
    {
        Camera cam = Camera.main;
        float halfHeight = cam.orthographicSize;
        float halfWidth = halfHeight * cam.aspect;

        Vector3 pos = transform.position;

        if (pos.x > halfWidth)
            pos.x = -halfWidth;
        else if (pos.x < -halfWidth)
            pos.x = halfWidth;

        if (pos.y > halfHeight)
            pos.y = -halfHeight;
        else if (pos.y < -halfHeight)
            pos.y = halfHeight;

        transform.position = pos;
    }
}
