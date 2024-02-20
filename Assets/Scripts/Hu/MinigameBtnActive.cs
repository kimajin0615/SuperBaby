using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameBtnActive : MonoBehaviour
{
    public GameObject WBtn;
    public GameObject BBtn;
    public GameObject SBtn;

    public GameObject Water;
    public GameObject Bench;
    public GameObject Stretch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Water)
        {
            WBtn.SetActive(true);

        }
        if (other.gameObject == Bench)
        {
            BBtn.SetActive(true);
        }
        if (other.gameObject == Stretch)
        {
            SBtn.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Water)
        {
            WBtn.SetActive(false);

        }
        if (other.gameObject == Bench)
        {
            BBtn.SetActive(false);
        }
        if (other.gameObject == Stretch)
        {
            SBtn.SetActive(false);
        }
    }
}
