using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smash : MonoBehaviour
{
    public GameObject brokenVersion;
    public GameObject brokenVersion2;
    public GameObject brokenVersion3;
    public GameObject brokenVersion4;
    public GameObject brokenVersion5;
    public float batThrust = 20f;
    public float impulseAmount = 1000f;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bat")
        {
            Debug.Log("Collision has happened with " + collision.transform.gameObject.name);


            Debug.Log(collision.impulse);

            //
            //Rigidbody myRigidBody = GetComponent<Rigidbody>();
            //myRigidBody.AddForce(collision.impulse * 100);



            //replace the object with the smaller objects 

            //this could be instantiate instead https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
            //example
            //Instantiate(brokenPrefab, new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z), Quaternion.identity);
            //...
            brokenVersion.transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z);
            brokenVersion2.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            brokenVersion3.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            brokenVersion4.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            brokenVersion5.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);





            // add the forces to those objects (multiplied)
            Rigidbody p1r = brokenVersion.gameObject.GetComponent<Rigidbody>();
            p1r.AddForce(collision.impulse * impulseAmount);
            p1r.AddForce(transform.position * batThrust);
            

         

            
            //get rid of the big cube
            GameObject.Destroy(gameObject);

        }
    }
}
