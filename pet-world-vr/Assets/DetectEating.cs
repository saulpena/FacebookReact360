using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEating : MonoBehaviour
{
    private Animator m_Animator;

    private GameObject FoodItem;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GameObject.FindGameObjectWithTag("Animal").GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            print("Yo dog");
            m_Animator.SetBool("Love", false);
            m_Animator.SetBool("Eating", true);
            FoodItem = collision.gameObject.transform.GetChild(0).gameObject;
            FoodItem.transform.parent = null;
            FoodItem.transform.parent = gameObject.transform;


            FoodItem.transform.localPosition = Vector3.zero;
            collision.gameObject.SetActive(false);


            StartCoroutine("StoppedEating");
                //meeple = this.gameObject.transform.GetChild(0);
        }
    }

    IEnumerator StoppedEating()
    {
        yield return new WaitForSeconds(1f);
        m_Animator.SetBool("Eating", false);
        yield return new WaitForSeconds(.5f);
        FoodItem.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
