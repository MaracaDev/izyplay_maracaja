using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutable : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float coins;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Sempre que a faca entrar em trigger contra algum objeto ativa essa função pra dar o efeito do corte
    public void Activate()
    {
        rb.isKinematic = false;
        Destroy(this.GetComponent<BoxCollider>());
        rb.AddForce(new Vector3(0,0,-2f), ForceMode.Impulse);
        GameManager.instance.coins += coins;
        
    }
}
