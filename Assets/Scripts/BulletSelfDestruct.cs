using System.Collections;
using UnityEngine;

public class BulletSelfDestruct : MonoBehaviour
{
    /**Garbage collection for bullets; saves
    excessive amounts of memory being used**/

    public float timeUntilDestruct;

    void Start()
    {
        Invoke("selfDestruct", timeUntilDestruct);
    }

    void selfDestruct()
    {
        Destroy(gameObject);
    }
}
