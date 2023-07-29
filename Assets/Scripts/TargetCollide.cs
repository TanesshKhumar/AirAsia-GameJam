using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.parent.gameObject.GetComponent<TargetScript>().NextTarget();
    }
}
