using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Animator _animator;
    public GameObject OpenPanel = null;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(true);
            // _animator.SetBool("open", true);
        }

    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            _animator.SetBool("open", false);
            OpenPanel.SetActive(false);
        }
    }

    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (IsOpenPanelActive)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OpenPanel.SetActive(false);
                _animator.SetBool("open", true);
            }
        }
    }
}
