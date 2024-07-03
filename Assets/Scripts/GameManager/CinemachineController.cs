using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineController : MonoBehaviour
{
    public CinemachineVirtualCamera cinemachineVirtualCamera;

    void Awake()
    {
        cinemachineVirtualCamera = FindObjectOfType<CinemachineVirtualCamera>();

        FollowPlayer();
    }

    public void ZoomCamera()
    {
        cinemachineVirtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>().m_TrackedObjectOffset = new Vector3(-8f, 6.82f,0);
        cinemachineVirtualCamera.m_Lens.OrthographicSize = 9f;
    }

    public void FollowPlayer()
    {
        cinemachineVirtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>().m_TrackedObjectOffset = new Vector3(0f, 6.82f,0);
        cinemachineVirtualCamera.m_Lens.OrthographicSize = 22f;
    }
}
