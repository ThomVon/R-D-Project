using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebcamScript : MonoBehaviour
{
    [SerializeField] private RawImage img = default;
    private WebCamTexture webCam;

    private void Start()
    {
        webCam = new WebCamTexture();
        if (!webCam.isPlaying)
        {
            webCam.Play();
            img.texture = webCam;
        }
    }
}
