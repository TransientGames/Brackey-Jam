using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate : MonoBehaviour
{
    [SerializeField] private List<GameObject> _actors = new List<GameObject>();
    public UIManager uiManager;
    private enum type {Activate, Deactivate, Toggle};
    [SerializeField] private type _type;

    private bool _complete = false;
    private List<PlayerStates> _charactersInside = new List<PlayerStates>();
    private string _action;
    private bool playerActive = false;

    private void Start()
    {
        if (_type == type.Deactivate)
        {
            _action = "Deactivate";
        }
        else
        {
            _action = "Activate";
        }
    }

    private void Update()
    {
        playerActive = false;
        foreach (PlayerStates character in _charactersInside)
        {
            if (playerActive == false && character.isActive)
            {
                playerActive = true;
            }
        }

        if (_charactersInside.Count > 0 && playerActive && _complete == false)
        {            
            uiManager.UpdateTargetText("Press E to " + _action);

            if (Input.GetKeyDown(KeyCode.E) && _complete == false)
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
                        FindObjectOfType<AudioManager>().Play("Shutdown");
                    }
                }
            }            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && _complete == false)
        {
            _charactersInside.Add(other.GetComponent<PlayerStates>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _charactersInside.Remove(other.GetComponent<PlayerStates>());
            uiManager.UpdateTargetText("");
        }
    }
}
