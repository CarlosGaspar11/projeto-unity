using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject pontoInteresse;

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
    }

    private void OnTriggerExit(Collider other)
    {
        pontoInteresse.SetActive(false);
    }
}
