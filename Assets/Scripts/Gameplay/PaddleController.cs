using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    private float screenHalfWidth;
    private float paddleHalfWidth;

    /// <summary>画面幅とパドル幅を計算してキャッシュする</summary>
    private void Start()
    {
        Camera cam = Camera.main;
        screenHalfWidth = cam.orthographicSize * cam.aspect;

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        paddleHalfWidth = sr != null ? sr.bounds.size.x / 2f : transform.localScale.x / 2f;
    }

    /// <summary>キーボード入力に応じてパドルを水平移動させる</summary>
    private void Update()
    {
        float horizontal = 0f;

        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
            horizontal -= 1f;
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
            horizontal += 1f;

        Vector3 movement = new Vector3(horizontal * moveSpeed * Time.deltaTime, 0f, 0f);
        transform.Translate(movement);

        ClampPosition();
    }

    /// <summary>パドルの位置を画面内に制限する</summary>
    private void ClampPosition()
    {
        float clampedX = Mathf.Clamp(transform.position.x, -screenHalfWidth + paddleHalfWidth, screenHalfWidth - paddleHalfWidth);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
