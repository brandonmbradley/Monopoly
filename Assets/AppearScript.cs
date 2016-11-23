using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AppearScript : MonoBehaviour
{

    public GameObject rent;
    public GameObject hover;
    public GameObject properties;

    // Use this for initialization
    void Start ()
    {
    rent.gameObject.SetActive(false);
    hover.gameObject.SetActive(true);
    properties.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void renton()
    {
        rent.gameObject.SetActive(true);
        properties.gameObject.SetActive(true);
        hover.gameObject.SetActive(false);
    }

    public void rentoff()
    {
        rent.gameObject.SetActive(false);
        properties.gameObject.SetActive(false);
        hover.gameObject.SetActive(true);
    }
}
