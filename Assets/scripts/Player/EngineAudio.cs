using UnityEngine;

public class EngineAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clipInitiate;
    public AudioClip clipRunning;
    public AudioClip clipStopping;
    public float engineRestartTime = 2f;

    private void Start()
    {
        Initiate();
    }

    public void Initiate()
    {
        audioSource.clip = clipInitiate;
        audioSource.Play();
        Invoke(nameof(PlayRunning), clipInitiate.length);
    }

    private void PlayRunning()
    {
        audioSource.clip = clipRunning;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void Stopping()
    {
        audioSource.clip = clipStopping;
        audioSource.Play();
        audioSource.Pause();
        Invoke(nameof(ResumeEngine), engineRestartTime);
    }

    private void ResumeEngine()
    {
        audioSource.UnPause();
        Initiate();
    }
}
