using UnityEngine;

public class Pewpew : MonoBehaviour
{
    //public Transform firePoint;//vart den skjuter ifrån
    public GameObject bulletPrefab;//skottet
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))// vad du trycker på för att skjuta
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);//positionen den firear från
        }
    }
    void Shoot()
    {
        //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);//positionen den firear från
    }
}
