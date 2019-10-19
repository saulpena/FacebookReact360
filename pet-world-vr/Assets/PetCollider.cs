using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetCollider : MonoBehaviour
{
    private bool IsPetting;
    private Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GameObject.FindGameObjectWithTag("Animal").GetComponent<Animator>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PetHead") {
            m_Animator.SetBool("Love", true);
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PetHead")
        {
            m_Animator.SetBool("Love", false);
        }
    }
}
