using UnityEditor;

[CustomEditor(typeof(Interactable), true)]
public class InteractableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interactable interactable = (Interactable)target;
        base.OnInspectorGUI();
        if (interactable.useEvents)
        {
            if (interactable.GetComponent<InteractionEvent>() == null)
                interactable.gameObject.AddComponent<InteractionEvent>();
        }
        else
        {
            // We are not using events. Remove the component
            if (interactable.GetComponent<InteractionEvent>() != null)
                DestroyImmediate(interactable.GetComponent<InteractionEvent>());
        }
    }
}
