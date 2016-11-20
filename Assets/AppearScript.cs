using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AppearScript : MonoBehaviour
{

    public GameObject rent;

	// Use this for initialization
	void Start ()
    {
    rent.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void renton()
    {
        rent.gameObject.SetActive(true);
    }

    public void rentoff()
    {
        rent.gameObject.SetActive(false);
    }
}
