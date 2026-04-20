using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab;

    void Start()
    {
        for (int x = 0; x < 3; x++)
        {
            Vector3 pos = new Vector3(x * 2.5f - 2.5f, 0, 0);
            GameObject block = Instantiate(blockPrefab, pos, Quaternion.identity);

            // 色変えてみる
            SpriteRenderer sr = block.GetComponent<SpriteRenderer>();
            sr.color = Color.red;
        }
    }
}
