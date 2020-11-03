using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PageFive : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour tb;
    public new AudioSource audio;
    public new AudioSource back;
    [SerializeField] Animator menAnimator;

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
            menAnimator.enabled = true;
        }

        else
        {
            audio.Stop();
            back.Stop();
            menAnimator.enabled = false;
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
