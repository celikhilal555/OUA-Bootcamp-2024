using UnityEngine;

public class ItemCollectController : MonoBehaviour
{
    public float CollectRange = 2.0f;
    public Transform HandPosition;
    public Camera Camera;
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
