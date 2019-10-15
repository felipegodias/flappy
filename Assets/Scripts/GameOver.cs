using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private Color currentColor;
    private Vector3 currentPosition;

    private float time;

    private void Start()
    {
        currentColor = new Color(1, 1, 1, 0);
        currentPosition = transform.position;
        GetComponent<SpriteRenderer>().color = currentColor;
    }

    private void Update()
    {
        currentColor = Color.Lerp(currentColor, Color.white, Time.deltaTime * 2);
        GetComponent<SpriteRenderer>().color = currentColor;

        currentPosition = Vector3.Lerp(currentPosition, new Vector3(0, 0.5f, -4), Time.deltaTime * 2);
        transform.position = currentPosition;

        time += Time.deltaTime;
        if (time > 2 && Input.GetMouseButtonDown(0)) SceneManager.LoadScene("Game");
    }
}