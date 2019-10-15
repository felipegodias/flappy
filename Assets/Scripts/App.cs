using UnityEngine;

public class App : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Screen.SetResolution(432, 768, FullScreenMode.Windowed);
    }
}