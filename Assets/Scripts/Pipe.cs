using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed;

    public GameManager gameManager;

    private float GenRandomHeight()
    {
        var rand = Random.value;
        return -0.15f + rand * 0.7f;
    }

    // Start is called before the first frame update
    private void Awake()
    {
        var pos = transform.position;
        pos.y = GenRandomHeight();
        transform.position = pos;
    }

    // Update is called once per frame
    private void Update()
    {
        if (gameManager.IsGameOver() || !gameManager.IsGameStarted()) return;

        var pos = transform.position;
        pos.x += -moveSpeed * Time.deltaTime;

        if (pos.x < -0.75f)
        {
            pos.x = 0.75f;
            pos.y = GenRandomHeight();
        }

        transform.position = pos;
    }
}