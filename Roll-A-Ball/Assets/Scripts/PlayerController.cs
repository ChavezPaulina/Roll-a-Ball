using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed = 800.0f;
    public Text scoreText;
    private int count = 0;
    public Text winText;


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other) //ball enters a trigger collider
    {
        if (other.gameObject.tag == "PickUp") //object that was entered has the tag "Pickup"
        {
            other.gameObject.SetActive(false);  //Then set that object to be inactive
            count += 1;
            scoreText.text = "Score: " + count;

            if (count >= 18)
            {
                GameManager.instance.Win();
            }


        }

    }

}
  



