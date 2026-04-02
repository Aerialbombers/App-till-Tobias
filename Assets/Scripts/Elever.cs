using UnityEngine;

public class Elever : MonoBehaviour
{
    public GameObject[] elev;

    void Start()
    {

    }

    void Update()
    {

    }

    public void ShowStudent(int index)
    {
        print(elev[index].name);
    }
}