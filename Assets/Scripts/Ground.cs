using UnityEngine;

public class Ground : MonoBehaviour
{
    public float moveSpeed;

    public GameManager gameManager;

    // Update is called once per frame
    private void Update()
    {
        if (gameManager.IsGameOver()) return;

        var pos = transform.position;
        pos.x += -moveSpeed * Time.deltaTime;

        if (Mathf.Abs(pos.x) > 0.083f) pos.x = 0.083f;

        transform.position = pos;
    }
}