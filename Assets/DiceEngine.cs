using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DiceEngine : MonoBehaviour {

    public GameObject diceRoll;
    public GameObject diceOne;
    public GameObject diceTwo;
    public GameObject rollText;
    public float rotationsPerMinute = 10.0f;
    private float canThrowDice = 4.0f;
    private bool diceThrown = false;
    private bool rolling = false;

    // Use this for initialization
    void Start () {

        diceOne.gameObject.SetActive(false);
        diceTwo.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (diceThrown)
        {
            canThrowDice -= Time.deltaTime;

            if (canThrowDice <= 0)
            {
                diceThrown = false;
                canThrowDice = 3.0f;

                Renderer rend = diceRoll.gameObject.GetComponent<Renderer>();
                rend.enabled = true;
                Renderer rend2 = rollText.gameObject.GetComponent<Renderer>();
                rend2.enabled = true;

                rolling = false;

            }

            if (canThrowDice >= 2.8f)
            {
                
                //diceOne.GetComponent<Rigidbody>().AddForce(Vector3.down * 3.0f);
               // diceTwo.GetComponent<Rigidbody>().AddForce(Vector3.down * 3.0f);

            }
        }




        diceRoll.transform.Rotate(0, 0, 6.0f * rotationsPerMinute * Time.deltaTime);
    }

    void OnMouseDown()
    {
        if (diceThrown == false)
        {

            rolling = true;

            diceOne.gameObject.SetActive(true);
            diceTwo.gameObject.SetActive(true);

            diceOne.transform.position = new Vector3(1.226f, 77.0f, 0.597f);
            diceTwo.transform.position = new Vector3(1.27f, 77.0f, 0.46f);


            Renderer rend = diceRoll.gameObject.GetComponent<Renderer>();
            rend.enabled = false;
            Renderer rend2 = rollText.gameObject.GetComponent<Renderer>();
            rend2.enabled = false;

            diceThrown = true;

        }
           
    }
}
