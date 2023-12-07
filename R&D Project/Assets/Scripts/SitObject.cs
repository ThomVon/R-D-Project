using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitObject : MonoBehaviour
{
    [SerializeField] private Transform _sitPosition;
    public Transform GetSitPosition() => _sitPosition;
}
