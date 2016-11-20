using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AppearProperties: MonoBehaviour
{

    public GameObject hover;
    public GameObject properties;

    // Use this for initialization
    void Start()
    {
        hover.gameObject.SetActive(true);
        properties.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void renton()
    {
        properties.gameObject.SetActive(true);
        hover.gameObject.SetActive(false);
    }

    public void rentoff()
    {
        properties.gameObject.SetActive(false);
        hover.gameObject.SetActive(true);
    }
}