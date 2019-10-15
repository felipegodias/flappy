using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public GameManager gameManager;

    private void Update()
    {
        var textRenderers = GetComponentsInChildren<Text>();
        foreach (var textRenderer in textRenderers)
            if (gameManager.IsGameStarted())
                textRenderer.text = gameManager.GetPoints().ToString();
            else
                textRenderer.text = string.Empty;
    }
}