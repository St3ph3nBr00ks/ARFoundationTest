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
        ResetOpenUrl();
    }

    private void Awake()
    {
        ResetOpenUrl();
    }

    public void ResetOpenUrl()
    {
        urlOpen = false;
    }

    [SerializeField]
    float openWebsiteDelay;

    float openWebsiteDelayTimer;

    void Update()
    {
        //Debug.Log(videoPlayer.frame + " / " + (long)videoPlayer.frameCount);

        // If the video has reached its end point or is close enough, open the website.
        if (urlOpen == false && (long)videoPlayer.frameCount - videoPlayer.frame < 5)
        {
            Debug.Log("video finished.");

            urlOpen = true;

            websiteOpenDelayCo = StartCoroutine(websiteOpenDelay());
        }
    }

    Coroutine websiteOpenDelayCo;

    IEnumerator websiteOpenDelay()
    {
        openWebsiteDelayTimer = 0;

        while (openWebsiteDelayTimer < openWebsiteDelay)
        {
            openWebsiteDelayTimer += Time.deltaTime;

            yield return null;
        }

        // Open the website
        Application.OpenURL(openUrl);

        urlOpen = true;

        websiteOpenDelayCo = null;

        yield break;
    }
}
