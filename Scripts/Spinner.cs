using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xAngle = 0f;
    [SerializeField] private float yAngle = 0f;
    [SerializeField] private float zAngle = 0f;

    // Update is called once per frame
    void Update() // Unity tarafından update her karede çağrılır
    {
        transform.Rotate(xAngle, yAngle, zAngle);
        // (1, 1, 1) ise x, y ve z açılarına her karede 1 derece ekler
    }
}

// rotation y'yi değiştirdikçe nesneyi döndüreceğiz

