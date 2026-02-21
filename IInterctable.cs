using UnityEngine;

public class IInterctable : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider [] coliderArray  = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider colider in coliderArray)
            {
                if (colider.TryGetComponent(out ObjectInteract objInteractable))
                {
                    objInteractable.Interact();
                }
                else if (colider.TryGetComponent(out PhoneInteraction phoneInteraction))
                {
                    phoneInteraction.Interact();
                }
                else if (colider.TryGetComponent(out LightController lightController))
                {
                    lightController.Interact();
                }
                else if (colider.TryGetComponent(out TVController tvController))
                {
                    tvController.Interact();
                }
            }
        }
    }

    public ObjectInteract GetInteractibleObject()
    {
        float interactRange = 2f;
        Collider [] coliderArray  = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider colider in coliderArray)
        {
            if (colider.TryGetComponent(out ObjectInteract objInteractable))
            {
                return objInteractable;
            }
        }
        return null;
    }
    
    public PhoneInteraction GetInteractiblePhone()
    {
        float interactRange = 2f;
        Collider [] coliderArray  = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider colider in coliderArray)
        {
            if (colider.TryGetComponent(out PhoneInteraction phoneInteractable))
            {
                return phoneInteractable;
            }
        }
        return null;
    }
    public LightController GetLightController()
    {
        float interactRange = 2f;
        Collider [] coliderArray  = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider colider in coliderArray)
        {
            if (colider.TryGetComponent(out LightController lightController))
            {
                return lightController;
            }
        }
        return null;
    }
    public TVController GetTVController()
    {
        float interactRange = 2f;
        Collider [] coliderArray  = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider colider in coliderArray)
        {
            if (colider.TryGetComponent(out TVController tvController))
            {
                return tvController;
            }
        }
        return null;
    }
    
}
