using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColourCube : Interactable
{
    private MeshRenderer mesh;
    [SerializeField] private Color[] colours;
    private int colourIndex; // default value is 0
    [SerializeField] private float rotationSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = Color.red;
    }

    private void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }

    protected override void Interact()
    {
        colourIndex++;
        if (colourIndex >= colours.Length)
        {
            colourIndex = 0;
        }
        mesh.material.color = colours[colourIndex];
    }
}
