using UnityEngine;
using UnityEngine.Video;

public class SimpleVideoControls : MonoBehaviour
{
    private VideoPlayer vp;

    void Start()
    {
        vp = GetComponent<VideoPlayer>();
    }

    public void PlayVideo()
    {
        vp.Play();
    }

    public void PauseVideo()
    {
        vp.Pause();
    }

    public void StopVideo()
    {
        vp.Stop();
    }
}
