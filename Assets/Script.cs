using UnityEngine.Video;
using UnityEngine;

public class SimpleVideoPlayer : MonoBehaviour
{
    private VideoPlayer vp;

    void Start()
    {
        vp = GetComponent<VideoPlayer>();
       // vp.Play();
    }

    public void Play()
    {
        vp.Play();
    }
    public void Pause()
    {
        vp.Pause();
    }
}