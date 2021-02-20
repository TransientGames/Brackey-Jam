using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate : MonoBehaviour
{
    [SerializeField] private List<GameObject> _actors = new List<GameObject>();
    public UIManager uiManager;
    private enum type {Activate, Deactivate, Toggle};
    [SerializeField] private type _type;

    private bool _activatable = false;
    private bool _complete = false;


    private void Update()
    {
        if (_activatable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (_type == type.Activate)
                {
                    foreach (GameObject actor in _actors)
                    {
                        actor.SetActive(true);
                    }
                    uiManager.UpdateTargetText("");
                    _complete = true;
                }
                else if (_type == type.Deactivate)
                {
                    foreach (GameObject actor in _actors)
                    {
                        actor.SetActive(false);
                    }
                    uiManager.UpdateTargetText("");
                    FindObjectOfType<AudioManager>().Play("Shutdown");
                    _complete = true;
                }
                else
                {
                    foreach (GameObject actor in _actors)
                    {
                        actor.SetActive(!actor.activeSelf);
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && _complete == false)
        {
            _activatable = true;
            string action;
            if (_type == type.Deactivate)
            {
                action = "Deactivate";
            }
            else
            {
                action = "Activate";
            }

            uiManager.UpdateTargetText("Press E to " + action);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _activatable = false;
            uiManager.UpdateTargetText("");
        }
    }
}
