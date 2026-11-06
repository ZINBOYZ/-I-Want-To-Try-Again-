using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class VideoFixer : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    

    IEnumerator Start()
    {
        // Hide the video panel initially to avoid grey/black artifact frames
        

        videoPlayer.Stop();
        videoPlayer.Prepare();

        // Wait until the video is fully prepared by the SDK
        while (!videoPlayer.isPrepared)
        {
            yield return null;
        }

        // Force frame to 0 and begin playback
        videoPlayer.frame = 0;
        videoPlayer.Play();

        // Wait until frame 0/1 is actively rendering
        while (videoPlayer.frame < 1)
        {
            yield return null;
        }

        // Reveal the panel once the valid frame is showing
        
    }
}
