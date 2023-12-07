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
            var asdf = args.interactableObject.transform.gameObject.GetComponent<SitObject>().GetSitPosition();
            _xrRig.transform.position = asdf.position;
            _xrRig.transform.rotation = asdf.rotation;
        }
    }
}
