using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PageSix : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour tb;
    public new AudioSource audio;
    [SerializeField] Animator avengersAnimator;
    [SerializeField] Animator logoAnimator;
    [SerializeField] Animator capAnimator;
    [SerializeField] Animator tonyAnimator;
    [SerializeField] Animator thorAnimator;
    [SerializeField] Animator natAnimator;
    [SerializeField] Animator hulkAnimator;
    [SerializeField] Animator hawkAnimator;

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
            avengersAnimator.enabled = true;
            logoAnimator.enabled = true;
            capAnimator.enabled = true;
            tonyAnimator.enabled = true;
            thorAnimator.enabled = true;
            natAnimator.enabled = true;
            hulkAnimator.enabled = true;
            hawkAnimator.enabled = true;
        }
        else
        {
            audio.Stop();
            avengersAnimator.enabled = false;
            logoAnimator.enabled = false;
            capAnimator.enabled = false; 
            tonyAnimator.enabled =false; 
            thorAnimator.enabled =false; 
            natAnimator.enabled = false; 
            hulkAnimator.enabled =false;
            hawkAnimator.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
