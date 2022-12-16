using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UnlockByPassword : MonoBehaviour
{

    public GameObject passwordMenu;
    public TMP_InputField passwordField;
    public GameObject error;
    public Animator LeftGate, RightGate;
    private string _password = "5356";
    
    private void Start()
    {
        error.SetActive(false);
        passwordMenu.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            passwordMenu.SetActive(true);
        }
    }

    private void Update()
    {
        if (passwordField.text.Length == 4)
        {

        }
    }


    //buttons script area

    public void one()
    {
        passwordField.text += "1";
    }
    public void two()
    {
        passwordField.text += "2";
    }
    public void three()
    {
        passwordField.text += "3";
    }
    public void four()
    {
        passwordField.text += "4";
    }
    public void five()
    {
        passwordField.text += "5";
    }
    public void six()
    {
        passwordField.text += "6";
    }
    public void seven()
    {
        passwordField.text += "7";
    }
    public void eight()
    {
        passwordField.text += "8";
    }
    public void nine()
    {
        passwordField.text += "9";
    }



    public void back()
    {
        passwordField.text = "";
        Time.timeScale = 1;
        passwordMenu.SetActive(false);
        error.SetActive(false);
    }

    public void check()
    {
        if (passwordField.text == _password)
        {

            LeftGate.SetTrigger("GateLeft");
            RightGate.SetTrigger("GateRight");
            passwordMenu.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            error.SetActive(true);
        }
    }





}
