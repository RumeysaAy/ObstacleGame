using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // iki collider birbiriyle çarpıştığında/temas ettiğinde gerçekleşecek olan olaylar:
    // çarpışma olduğu anda çağrılır çarpışma devam ederken veya bittiğinde çağrılmaz
    private void OnCollisionEnter(Collision other) // duvara bir nesne çarptığında çağrılır
    {
        // bu cs dosyası duvarlarda bulunduğundan duvarlara temas olduğunda metot çalıştırılır
        // other duvara çarpan nesnedir.
        // dolayısıyla oyuncu duvara çarptığında bu metot çağrılır

        if (other.gameObject.tag == "Player") // sadece oyuncuyla vurursak kırmızıya dönmesini istiyoruz.
        {
            // Mesh Renderer, duvarın materyal gibi görünmesini sağlar.
            GetComponent<MeshRenderer>().material.color = Color.red;
            // duvara oyuncu çarptığında duvar kırmızı olur.

            // kırmızı olan nesnenin etiketi hit olur.
            gameObject.tag = "Hit"; // bu cs dosyasının bulunduğu nesneye oyuncu çarptıysa nesnenin etiketi hit olur.
        }
    }
}

// oyuncu zaten vurulmuş bir şeye vurursa, o zaman puanı artırmayacağım
// bunun için Tag'ı Hit ise puanın artmamasını sağlayacağım

