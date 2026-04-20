using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction = Vector2.up;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // 初速（斜めに飛ばす）
        rb.linearVelocity = new Vector2(1, 1).normalized * speed;
    }

    // void Update()
    // {
    //     // 方向入力（押した瞬間だけ変更）
    //     Vector2 input = Vector2.zero;

    //     if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
    //         input = Vector2.left;

    //     if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
    //         input = Vector2.right;

    //     if (Keyboard.current.upArrowKey.wasPressedThisFrame)
    //         input = Vector2.up;

    //     if (Keyboard.current.downArrowKey.wasPressedThisFrame)
    //         input = Vector2.down;

    //     // 入力があれば方向更新
    //     if (input != Vector2.zero)
    //     {
    //         direction = input.normalized;
    //     }

    //     // 常に進む
    //     transform.Translate(direction * speed * Time.deltaTime);
    // }

    // void Update()
    // {
    //     Vector2 move = Vector2.zero;

    //     if (Keyboard.current.leftArrowKey.isPressed)
    //         move.x = -1;

    //     if (Keyboard.current.rightArrowKey.isPressed)
    //         move.x = 1;

    //     if (Keyboard.current.upArrowKey.isPressed)
    //         move.y = 1;

    //     if (Keyboard.current.downArrowKey.isPressed)
    //         move.y = -1;

    //     transform.Translate(move * speed * Time.deltaTime);
    // }
}
