using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private float distance = 3f;
    [SerializeField] private LayerMask mask;
    private PlayerUI playerUI;

    // Start is called before the first frame update
    void Start()
    {
        playerUI = GetComponent<PlayerUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // When not looking at an interactable, the promptMessage should be empty
        playerUI.UpdateText(string.Empty);
        // Create a ray at the center of the camera, shooting outwards
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        // Draws the ray from the origin towards the camera's direction with a given distance
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo; // Variable to store our collision information
        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                playerUI.UpdateText(hitInfo.collider.GetComponent<Interactable>().GetPromptMessage());
            }
        }
    }
}
