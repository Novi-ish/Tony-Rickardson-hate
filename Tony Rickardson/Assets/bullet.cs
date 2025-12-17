using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class bullet : MonoBehaviour
{
    
    // Start is called before the first frame update
    public float speed = 20f;//hur snabbt skotten �ker
    //public Rigidbody2D rb;
    //Vector3 dir = new Vector3(0, 1, 0);//vilken rikting den skjutter
    [SerializeField] int pop = 1;//g�r s� clonerna f�rsvinner fr�n hierarchy
 
    void Start()
    {
       // rb.linearVelocity = transform.up * speed;//den �ker upp
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position += dir * speed * Time.deltaTime;//hur jag r�r mig ish

        if (gameObject.name == "bullet(Clone)")
        {
            Destroy(gameObject, pop);// f�rst�r clonen i hierarchy
        }


        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}
