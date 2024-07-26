using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.XR;

public class ItemCollectController : MonoBehaviour
{
    public float CollectRange = 2.0f;
    public Transform HandPosition;
    public Camera Camera;
    public GameObject Flashlight;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, CollectRange))
            {
                if (hit.collider.CompareTag("Key"))
                {
                    CollectItem(hit.collider.gameObject);
                }
            }
            if (Physics.Raycast(ray, out hit, CollectRange))
            {
                if (hit.collider.TryGetComponent(out FlashlightController flashlight))
                {
                    flashlight.gameObject.SetActive(false);
                    Flashlight.SetActive(true);
                }
            }
        }
    }

    void CollectItem(GameObject item)
    {
        Debug.Log("Eþya alýndý: " + item.name);
        item.transform.SetParent(HandPosition); 
        item.transform.localPosition = Vector3.zero; 
        item.transform.localRotation = Quaternion.identity;
        //item.SetActive(false);
    }
}
