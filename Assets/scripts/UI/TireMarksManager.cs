using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireMarksManager : MonoBehaviour
{
    public GameObject tireMarkPrefab; // Assign the small circle prefab in the Inspector

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Road"))
        {
            ContactPoint contactPoint = collision.GetContact(0);
            GameObject tireMark = Instantiate(tireMarkPrefab, contactPoint.point, Quaternion.identity);
            Destroy(tireMark, 2f); // Adjust the time you want the tire mark to stay visible
        }
    }

}
