using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; // left - right veya a - d
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; // down - up veya s - d

        transform.Translate(xValue, 0f, zValue);
    }
}

/* Edit > Project Settings > Input Manager > Axes
Yön Tuşları: 
- Yatay(Horizontal): sol(negatif)(left)(a) - sağ(pozitif)(right)(d)
- Dikey(Vertical): aşağı(negatif)(down)(s) - yukarı(pozitif)(up)(w)
*/

/*


####### xValue = Input.GetAxis("Horizontal")

- 2 bilgisayardan birinde saniyede 2000 kare vardır. Diğerinde ise saniyede 100 kare vardır. Dolayısıyla biri diğerinden daha hızlıdır.
- Update her bir karede çalıştığı için oyun bilgisayarın hızına bağlı olur.
- Yani update yavaş bir bilgisayarda saniyede 100 kez çalışabilir.
- Hızlı bir bilgisayarda saniyede 2000 kez çalışabilir.

####### xValue = Input.GetAxis("Horizontal") * Time.deltaTime 

- Time.deltaTime kullanarak Unity bize her karenin ne kadar sürede yürütüldüğünü söyleyebilir.
- bize her karenin yürütülmesinin ne kadar sürdüğünü söyleyebilir.
- Saniyedeki her karenin ne zaman yürütüleceğini söyler.
- Böylece oyun kare hızından bağımsız hale getirilebilir.
- Time.deltaTime kare hızından bağımsız olmamıza yardımcı olur.
- Hızlı ve yavaş bilgisayarlarda aynı şekilde davranır.

- Her karede bir birim sola hareket ettirmek istiyorsak
- Yavaş saniyede 10 kare, hızlı saniyede 100 kare (fps)
- Her iki bilgisayarda aynı sonucu istiyorsak
- Yavaş bilgisayardaki bir karenin süresi 1/10=0.1 saniye (duration of frame)
- Hızlı bilgisayardaki bir karenin süresi 1/100=0.01 saniye

Distance per second
- Yavaş: 1*10*0.1 = 1
- Hızlı: 1*100*0.01 = 1
- 1 birim sol*fps*delta= 1 birim sol

- X değerini çevirirken, bu x değerinin kare hızından bağımsız olmasını istediğimizi söylemektir.
- Nesnemizi ekran boyunca hareket ettirmek için kullandığımız her bir karede tek bir değer oluşturacağız.


*/
