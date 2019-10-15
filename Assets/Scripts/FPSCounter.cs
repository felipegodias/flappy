using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public int fps;
    public float time;
    public Text textRenderer;

    // Update is called once per frame
    private void Update()
    {
        ++fps;
        time += Time.deltaTime;
        if (time >= 1)
        {
            textRenderer.text = fps.ToString();
            fps = 0;
            time = 0;
        }
    }
}