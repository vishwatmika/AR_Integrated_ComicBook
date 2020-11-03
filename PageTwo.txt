using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Vuforia;

public class PageTwo : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour tb;
    [SerializeField] Animator animator;
    public new AudioSource audio;
    public new AudioSource back;

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
            animator.enabled =true;
            audio.Play();
            back.Play();
        }
        else { animator.enabled = false; audio.Stop(); back.Stop();}
    }


    // Update is called once per frame
    void Update()
    {

    }
}
