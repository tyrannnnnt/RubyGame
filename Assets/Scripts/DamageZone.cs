using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        UnityEngine.Debug.Log("touched");
        if (controller != null)
        {
            UnityEngine.Debug.Log("damaged");
            controller.ChangeHealth(-1);
        }
    }

}
