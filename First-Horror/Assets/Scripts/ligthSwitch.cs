using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    public GameObject inttext, light1, light2, light3, light4, light5, light6;
    public bool toggle = true, interactable;
    public Renderer lightBulb1, lightBulb2, lightBulb3, lightBulb4, lightBulb5, lightBulb6;
    public Material offlight, onlight;
    public AudioSource lightSwitchSound;
    public Animator switchAnim;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;
                //lightSwitchSound.Play();
                switchAnim.ResetTrigger("press");
                switchAnim.SetTrigger("press");
            }
        }
        if(toggle == false)
        {
            light1.SetActive(false);
            light2.SetActive(false);
            light3.SetActive(false);
            light4.SetActive(false);
            light5.SetActive(false);
            light6.SetActive(false);
            lightBulb1.material = offlight;
            lightBulb2.material = offlight;
            lightBulb3.material = offlight;
            lightBulb4.material = offlight;
            lightBulb5.material = offlight;
            lightBulb6.material = offlight;
        }
        if (toggle == true)
        {
            light1.SetActive(true);
            light2.SetActive(true);
            light3.SetActive(true);
            light4.SetActive(true);
            light5.SetActive(true);
            light6.SetActive(true);
            lightBulb1.material = onlight;
            lightBulb2.material = onlight;
            lightBulb3.material = onlight;
            lightBulb4.material = onlight;
            lightBulb5.material = onlight;
            lightBulb6.material = onlight;
        }
    }
}
