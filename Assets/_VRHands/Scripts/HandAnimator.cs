using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class HandAnimator : MonoBehaviour
{
    public SteamVR_Action_Single grabAction = null;

    private Animator Animator = null;
    private SteamVR_Behaviour_Pose pose = null;

    private void Awake()
    {
        Animator = GetComponent<Animator>();
        pose = GetComponentInParent<SteamVR_Behaviour_Pose>();

        grabAction[pose.inputSource].onChange += Grab;
    }

    private void OnDestroy()
    {
        grabAction[pose.inputSource].onChange -= Grab;
    }

    private void OnTriggerEnter(Collider other)
    {
        Animator.SetBool("Point", true);
    }

    private void OnTriggerExit(Collider other)
    {
        Animator.SetBool("Point", false);
    }

    private void Grab(SteamVR_Action_Single action, SteamVR_Input_Sources source, float axis, float delta)
    {
        Animator.SetFloat("GrabBlend", axis);
    }
}
