using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] private float timeToWait = 3f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false; // Mesh renderer false ise nesneyi göremeyiz
        rigidbody.useGravity = false; // yer çekimi etki etmez
    }

    // Update is called once per frame
    void Update()
    {
        // Düşmeye başlamadan önce nesneyi göremeyeceğiz
        if (Time.time > timeToWait)
        {
            rigidbody.useGravity = true; // 3 saniye geçtikten sonra yer çekimi etkinleştirildi
            renderer.enabled = true; // nesne görünür kılındı

        }
    }
}

// Time.time: play tuşuna tıkladığımız andan itibaren geçen süredir (saniye)

// oyun ilk başladığında oyun nesnesi üzerindeki yer çekimini devre dışı bırakmak
// ve 3 saniyenin geçtiği noktaya geldiğimizde yer çekimini etkinleştirmek, 
// böylece daha sonra oyuncunun üzerine düşebilir.

// nesnenin fizik sisteminden etkilenmesi için rigidbody ekleriz
// Rigidbody > Use gravity = true ise yer çekimi aktif


