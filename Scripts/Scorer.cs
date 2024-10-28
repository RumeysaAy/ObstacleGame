using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0; // çeşitli nesnelere(collider) kaç kez çarptığımızı gösterir ve bir şeylere çarptıkça artar.

    // iki collider birbiriyle çarpıştığında/temas ettiğinde gerçekleşecek olan olaylar:
    // çarpışma olduğu anda çağrılır çarpışma devam ederken veya bittiğinde çağrılmaz
    private void OnCollisionEnter(Collision other)
    { // bu cs dosyasını oyuncuya ekledim dolayısıyla oyuncu bir nesneyle çarpıştığında bu metot çağrılır

        if (other.gameObject.tag != "Hit") // oyuncu daha önce bu nesneye vurmamışsa
        {
            hits++; // oyuncu her nesneye(collider olmalı) çarptığında hits 1 artar
            Debug.Log("Toplam çarpma sayısı: " + hits);
        }

    }
}

// oyuncu tag'ı Hit olan bir nesneye vurmuşsa daha önceden vurmuş demektir.
// bu yüzden skora eklenmez


