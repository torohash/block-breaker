using UnityEngine;

public class Block : MonoBehaviour
{
    // 何かとぶつかった瞬間に呼ばれる（両方にColliderがある & どちらかにRigidbody2Dがある）
    // Collision2D collision ->「ぶつかった相手の情報」が入ってる箱
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // collision.gameObject -> ぶつかった相手のオブジェクト
        // タグで判定してる どのPrefabかでの判断もできるけど、タグ使うのがきれいらしい
        // コンポーネント判定もいいらしい if (collision.gameObject.GetComponent<BallController>() != null)
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
}
