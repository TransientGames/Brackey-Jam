using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject doorBottom;
    public GameObject doorTop;
    private float _speed = 1.5f;
    private bool _open = false;

    private void Update()
    {
        if (_open)
        {
            doorBottom.transform.Translate(Vector3.down * _speed * Time.deltaTime);
            doorTop.transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _open = true;
            gameManager.EndGame();
            FindObjectOfType<AudioManager>().Play("Airlock");
        }
    }
}
