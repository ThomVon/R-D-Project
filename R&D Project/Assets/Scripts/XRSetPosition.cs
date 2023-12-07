using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRSetPosition : MonoBehaviour
{
    [SerializeField] private GameObject _xrRig;
    public void SetPosition(Transform transform)
    {
        _xrRig.transform.position = transform.position;
    }
}
