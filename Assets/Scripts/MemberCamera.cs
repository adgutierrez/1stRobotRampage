using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MemberCamera : MonoBehaviour
{
    [Serializable]
    public class AdvancedOptions
    {
        public bool updateCameraInUpdate;
        public bool updateCameraInFixedUpdate = true;
        public bool updateCameraInLateUpdate;
        public KeyCode switchViewKey = KeyCode.C;
    }

    public float smoothing = 6f;
    public Transform lookAtMember;
    public Transform frowardView;
    public Transform TopDownView;
    public AdvancedOptions advancedOptions;

    bool m_ShowingSideView;

    private void FixedUpdate()
    {
        if (advancedOptions.updateCameraInFixedUpdate)
            UpdateCamera();
    }

    private void Update()
    {
        if (Input.GetKeyDown(advancedOptions.switchViewKey))
            m_ShowingSideView = !m_ShowingSideView;

        if (advancedOptions.updateCameraInUpdate)
            UpdateCamera();
    }

    private void LateUpdate()
    {
        if (advancedOptions.updateCameraInLateUpdate)
            UpdateCamera();
    }

    private void UpdateCamera()
    {
        if (m_ShowingSideView)
        {
            transform.position = TopDownView.position;
            transform.rotation = TopDownView.rotation;
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, frowardView.position, Time.deltaTime * smoothing);
            transform.LookAt(lookAtMember);
        }
    }
}
