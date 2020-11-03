using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PageFour : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour tb;
    public new AudioSource audio;
    public new AudioSource back;
    public ParticleSystem particle;
    public ParticleSystem particle2;
    [SerializeField] Animator shipOneAnimator;
    [SerializeField] Animator shipTwoAnimator;
    [SerializeField] Animator meteorAnimator;

    // Start is called before the first frame update
    void Start()
    {
        tb = GetComponent<TrackableBehaviour>();
        if (tb)
            tb.RegisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            audio.Play();
            back.Play();
            particle.Play();

            var main = particle2.main;
            main.startDelay = 16.0f;
            particle2.Play();

            shipOneAnimator.enabled = true;
            shipTwoAnimator.enabled = true;
            meteorAnimator.enabled = true;
        }
        else
        {
            audio.Stop();
            back.Stop();
            particle.Stop();
            particle2.Play();
            shipOneAnimator.enabled = false;
            shipTwoAnimator.enabled = false;
            meteorAnimator.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
