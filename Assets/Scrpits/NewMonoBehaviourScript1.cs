using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    public GameObject pontoInteresse;
    public GameObject pontoInteresse2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        pontoInteresse.SetActive(true);
        pontoInteresse2.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        pontoInteresse.SetActive(false);
        pontoInteresse2.SetActive(false);
    }
}
