using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRInteractionExtender : MonoBehaviour
{
    [SerializeField] private GameObject _xrRig;

    public void OnSelect(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("Sit"))
        {
            //add code here to play animation
            var interactableTransform = args.interactableObject.transform.gameObject.GetComponent<SitObject>().GetSitPosition();
            _xrRig.transform.SetPositionAndRotation(interactableTransform.position, interactableTransform.rotation);
            //add code here to set the avatar to a sitting position
        }
    }
}
