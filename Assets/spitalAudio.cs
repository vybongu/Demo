using UnityEngine;
using UnityEngine.UI;
public class spitalAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public Text statusText; // Hiển thị trạng thái lên màn hình

    void Update()
    {
        // Nhấn 1 để chuyển sang 2D
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioSource.spatialBlend = 0f;
            if (statusText) statusText.text = "Mode: 2D Audio";
        }
        // Nhấn 2 để chuyển sang 3D
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            audioSource.spatialBlend = 1f;
            if (statusText) statusText.text = "Mode: 3D Audio (Spatial)";
        }
    }
}
