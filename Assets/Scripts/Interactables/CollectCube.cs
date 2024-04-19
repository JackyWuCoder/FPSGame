using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCube : Interactable
{
    [SerializeField] private GameObject particle;

    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    protected override void Interact()
    {
        Destroy(gameObject);
        Instantiate(particle, transform.position, Quaternion.identity);
    }
}
