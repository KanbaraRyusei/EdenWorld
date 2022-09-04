using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPlayer : MonoBehaviour
{
    Collider _collider;
    private void Awake()
    {
        _collider = GetComponent<CapsuleCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IBattleable ib))
        {
            ib.Battle();
        }
    }
}
