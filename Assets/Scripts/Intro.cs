using UnityEngine;

public class Intro : MonoBehaviour
{
    public GameManager gameManager;

    private void Update()
    {
        if (gameManager.IsGameStarted()) gameObject.SetActive(false);
    }
}