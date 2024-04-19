using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCube : Interactable
{
    [SerializeField] private GameObject particle;
    [SerializeField] private float rotationSpeed = 1;

    private void Start()
    {

        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    private void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }

    protected override void Interact()
    {
        Destroy(gameObject);
        Instantiate(particle, transform.position, Quaternion.identity);
    }
}
