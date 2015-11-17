using UnityEngine;
using System.Collections;

public class WallRotator : MonoBehaviour
{

    void Awake()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
