using System.Collections;
using UnityEngine;

public class DelayedColliderEnable : MonoBehaviour
{
    /** Script delays when the box collider enables; necessary
    so that bullet doesn't hit player's plane when fired**/

    public float afterSeconds;

    void Start()
    {
        Invoke("Trigger", afterSeconds);
    }

    // Update is called once per frame
    void Trigger()
    {
        transform.GetComponent<BoxCollider>().enabled = true;
    }
}
