using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform tf;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - tf.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, tf.position.z + offset.z);
    }

    public IEnumerator GotHit()
    {
        float time = 0;
        Vector3 startPosition = transform.position;
        Vector3 targetPosition = new Vector3(0, 4, -3.5f);

        while (time < 0.15f)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / 0.12f);
            time += Time.deltaTime;
            yield return null;
        }
        
        yield return new WaitForSeconds(0.2f);
        time = 0;
        while (time < 2.4f)
        {
            transform.position = Vector3.Lerp(targetPosition, startPosition, time / 2.4f);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = startPosition;
    }
}
