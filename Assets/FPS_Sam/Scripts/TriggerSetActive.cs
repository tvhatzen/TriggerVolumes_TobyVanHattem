using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud NSCC

public class TriggerSetActive : MonoBehaviour
{

    public Explosion explosion;

    void OnTriggerEnter(Collider other)
    {
        explosion.Main();
    }

}
