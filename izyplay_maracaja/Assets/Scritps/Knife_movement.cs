using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife_movement : MonoBehaviour
{
    public float torque_force;
    public float move_force;

    public Rigidbody rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //movimentação e rotação da faca
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(new Vector3(1, 3, 0) * move_force, ForceMode.Impulse);
            rb.AddTorque(new Vector3(0, 0, -2) * torque_force, ForceMode.Impulse);
        }
    }

    //Triggers da faca.
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("cut"))
        {
            other.GetComponent<Cutable>().Activate();
        }

        if (other.CompareTag("end"))
        {
            this.rb.isKinematic = true;
            print("venceu");
            GameManager.instance.coins *= other.GetComponent<End_wall>().bonus;
            
            StartCoroutine(win());
        }

        if (other.CompareTag("death"))
        {
            StartCoroutine(win());
        }
    }



    public IEnumerator win()
    {
        yield return new WaitForSeconds(2f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
