using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject intText;
    public bool interacable;
    public Animator doorAnim;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Main Camera"))
        {
            intText.SetActive(true);
            interacable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Main Camera"))
        {
            intText.SetActive(false);
            interacable = false;
        }
    }

    void Update()
    {
        if (interacable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
        } 
    }
}
