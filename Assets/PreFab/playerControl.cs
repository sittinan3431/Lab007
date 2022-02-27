using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControl : MonoBehaviour
{
    //Show score
    public Text scoreText;
    private float score;
    // movement
    public float speed;
    void Start()
    {
        score = 0.0f;
        scoreText.text = "score: "+ score.ToString();    
    }

    // Update is called once per frame
    void playerMovement(float speed){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0.0f,vertical);
        this.GetComponent<Rigidbody>().AddForce(movement*speed);
    }

    public void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("coid")){
            other.gameObject.SetActive(false);
            score = score + 1;
            //Debug.Log("Score:" + score.ToString());
            scoreText.text = "score: "+ score.ToString();
        }
    }
    void Update()
    {
        playerMovement(speed);
    }
}
