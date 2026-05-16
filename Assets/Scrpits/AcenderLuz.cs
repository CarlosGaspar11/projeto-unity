using UnityEngine;

public class AcenderLuz : MonoBehaviour
{
    public Light[] luzes;

    void Start()
    {
        foreach (Light luz in luzes)
            luz.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (Light luz in luzes)
            luz.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (Light luz in luzes)
            luz.enabled = false;
    }
}