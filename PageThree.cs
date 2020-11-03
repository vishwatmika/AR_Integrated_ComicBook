using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PageThree : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour tb;
    public new AudioSource audio;
    public new AudioSource back;
    public ParticleSystem particle;
    [SerializeField] Animator bookAnimator;
    [SerializeField] Animator hyperionAnimator;
    [SerializeField] Animator moonAnimator;
    [SerializeField] Animator marsAnimator;

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
            hyperionAnimator.enabled = true;
            bookAnimator.enabled = true;
            moonAnimator.enabled = true;
            marsAnimator.enabled = true;
            audio.Play();
            back.Play();
            particle.Play();
        }
        else 
        { 
            audio.Stop(); 
            back.Stop();
            hyperionAnimator.enabled = false;
            bookAnimator.enabled = false;
            moonAnimator.enabled = false;
            marsAnimator.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
