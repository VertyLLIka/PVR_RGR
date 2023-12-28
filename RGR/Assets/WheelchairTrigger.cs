using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelchairTrigger : MonoBehaviour
{
    [SerializeField] private Animator Target = null;
    [SerializeField] private string Trigger = "Enter your trigger";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Target.Play("Bed", 0, 0.0f);
            gameObject.SetActive(false);
        }
    }        
}