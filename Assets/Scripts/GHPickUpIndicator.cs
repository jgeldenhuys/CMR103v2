using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GHPickUpIndicator : OVRGrabbable
{
    Renderer r;

    AudioSource myAudioSource;
    public AudioClip soundFX;
    OVRHapticsClip ovrClip;

    // Start is called before the first frame update
#pragma warning disable CS0114 // 'GHPickUpIndicator.Start()' hides inherited member 'OVRGrabbable.Start()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
    void Start()
#pragma warning restore CS0114 // 'GHPickUpIndicator.Start()' hides inherited member 'OVRGrabbable.Start()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
    {
        base.Start();
        r = GetComponent<Renderer>();
        myAudioSource = GetComponent<AudioSource>();

        //create haptic clip 
        ovrClip = new OVRHapticsClip(soundFX);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);


        

        //add the sound play for the pickup
        myAudioSource.Play();


        //add the haptic to match the sound

        //and pass to correct controller
        if (hand.gameObject.name == "RightControllerAnchor")
        {
            OVRHaptics.RightChannel.Preempt(ovrClip);
        }
        else if (hand.gameObject.name == "LeftControllerAnchor")
        {
            OVRHaptics.LeftChannel.Preempt(ovrClip);
        }



    }


    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        r.material.color = Color.green;
    }
}