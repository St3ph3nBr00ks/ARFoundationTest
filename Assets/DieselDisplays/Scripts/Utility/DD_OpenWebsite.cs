using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class DD_OpenWebsite : MonoBehaviour
{
    [SerializeField]
    VideoPlayer videoPlayer;

    [SerializeField]
    string openUrl;

    public static bool urlOpen;

    private void Start()
    {
        urlOpen = false;
    }

    private void Awake()
    {
        urlOpen = false;
    }

    public void ResetOpenUrl()
    {
        urlOpen = false;
    }

    void Update()
    {
        Debug.Log(videoPlayer.frame + " / " + (long)videoPlayer.frameCount);

        // If the video has reached its end point or is close enough, open the website.
        if (urlOpen == false && (long)videoPlayer.frameCount - videoPlayer.frame < 5)
        {
            Debug.Log("video finished.");

            Application.OpenURL(openUrl);

            urlOpen = true;
        }
    }
}
