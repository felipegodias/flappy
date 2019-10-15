using UnityEngine;

public class FlappyController : MonoBehaviour
{
    private float currentAngle;

    private bool shouldUpdate = true;

    public GameManager gameManager;

    private void Awake()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (gameManager.IsGameStarted() && !gameManager.IsGameOver())
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * 2;
            }
            else if (!gameManager.IsGameStarted())
            {
                gameManager.StartGame();
                GetComponent<Rigidbody2D>().gravityScale = 1;
                GetComponent<Rigidbody2D>().velocity = Vector2.up * 2;
            }
        }

        if (shouldUpdate)
        {
            var velocity = Vector2.zero;
            if (Vector2.Distance(GetComponent<Rigidbody2D>().velocity, Vector2.zero) > Mathf.Epsilon)
                velocity = GetComponent<Rigidbody2D>().velocity.normalized;

            currentAngle += 0.05f * (velocity.y - currentAngle) * Time.deltaTime * 100;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, currentAngle * 60);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Ground" || collision.otherCollider.name == "Ground")
        {
            shouldUpdate = false;
            gameManager.GameOver();
            GetComponent<Animator>().SetTrigger("die");
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var colliderName = collider.name;

        if (colliderName == "PipeBottom" || colliderName == "PipeTop")
        {
            gameManager.GameOver();
            GetComponent<Animator>().SetTrigger("die");
        }
        else
        {
            gameManager.IncreasePoint();
        }
    }
}