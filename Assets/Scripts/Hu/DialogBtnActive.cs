using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBtnActive : MonoBehaviour
{
    public GameObject siaBtn;
    public GameObject siuBtn;
    public GameObject dabinBtn;
    public GameObject hyunBtn;

    public GameObject sia;
    public GameObject siu;
    public GameObject dabin;
    public GameObject hyun;
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
        if (other.gameObject == sia)
        {
            siaBtn.SetActive(true);

        }
        if (other.gameObject == siu)
        {
            siuBtn.SetActive(true);
        }
        if (other.gameObject == dabin)
        {
            dabinBtn.SetActive(true);
        }
        if (other.gameObject == hyun)
        {
            hyunBtn.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == sia)
        {
            siaBtn.SetActive(false);

        }
        if (other.gameObject == siu)
        {
            siuBtn.SetActive(false);
        }
        if (other.gameObject == dabin)
        {
            dabinBtn.SetActive(false);
        }
        if (other.gameObject == hyun)
        {
            hyunBtn.SetActive(false);
        }
    }
}
