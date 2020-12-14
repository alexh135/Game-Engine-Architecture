using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwPortal : MonoBehaviour
{
    public GameObject startPortal;
    public GameObject endPortal;


    void Start()
    {
        startPortal.SetActive(false);
        endPortal.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootPortal(startPortal);
            startPortal.SetActive(true);
        }
        if (Input.GetMouseButtonDown(1))
        {
            ShootPortal(endPortal);
            endPortal.SetActive(true);
        }
    }

    void ShootPortal(GameObject portal)
    {
        Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        RaycastHit hitInfo;
        if (Physics.Raycast(rayOrigin, out hitInfo))
        {
            Quaternion findNormal = Quaternion.LookRotation(hitInfo.normal);
            portal.transform.position = hitInfo.point;
            portal.transform.rotation = findNormal;
        }

    }
}

