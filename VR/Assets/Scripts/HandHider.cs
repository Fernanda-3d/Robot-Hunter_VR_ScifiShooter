using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandHider : MonoBehaviour
{
    private SkinnedMeshRenderer meshRenderer = null;
    private XRDirectInteractor interactor = null;

    private void Awake()
    {
        meshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        interactor = GetComponent<XRDirectInteractor>();

        interactor.onHoverEntered.AddListener(Hide);
        interactor.onHoverExited.AddListener(Show);

    }

    private void OnDestroy()
    {
        interactor.onHoverEntered.RemoveListener(Hide);
        interactor.onHoverExited.RemoveListener(Show);
    }

    private void Hide(XRBaseInteractable interactable)
    {
        meshRenderer.enabled = false;
    }

    private void Show(XRBaseInteractable interactable)
    {
        meshRenderer.enabled = true;
    }



}
