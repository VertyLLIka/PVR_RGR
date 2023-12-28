using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CoilheadTrigger : MonoBehaviour 
{
    [SerializeField] private GameObject DeathScreenUI;
    [SerializeField] private GameObject DeathEffectUI;
    [SerializeField] private TeleportationProvider providerTp;
    [SerializeField] private Animator Target = null;
    [SerializeField] private string Trigger = "Enter your trigger";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            Target.Play("CoilheadAtack", 0, 0.0f);
        }

        else if (other.CompareTag("Player"))
        {
            DeathScreenUI.SetActive(true);
            DeathEffectUI.SetActive(true);
            providerTp.enabled = false;
            gameObject.SetActive(false);
        }
    }      
}