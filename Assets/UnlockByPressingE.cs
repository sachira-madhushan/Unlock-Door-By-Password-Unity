using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnlockByPressingE : MonoBehaviour
{

    public GameObject message;
    private bool _gateOpenable=false;
    public Animator leftGate, rightGate;
    private void Start()
    {
        message.SetActive(false);
    }

    private void Update()
    {
        if (_gateOpenable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                leftGate.SetTrigger("GateLeft");
                rightGate.SetTrigger("GateRight");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _gateOpenable = true;
            message.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _gateOpenable = false;
            message.SetActive(false);
        }
    }
}
