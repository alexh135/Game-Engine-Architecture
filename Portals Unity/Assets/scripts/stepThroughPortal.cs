using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepThroughPortal : MonoBehaviour
{
    public GameObject exitPortal;
    public GameObject player;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Teleport());
        }
    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(0);
        player.transform.position = exitPortal.transform.position + exitPortal.transform.forward * 1f;
        player.transform.rotation = exitPortal.transform.rotation;
    }
}
