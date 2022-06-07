using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public GameObject myPrefab;
    public float Insert;

    private List<GameObject> namesOfDestroyedObjects = new List<GameObject>();
    private List<Vector3> posicionserpiente = new List<Vector3>();




    // Start is called before the first frame update
    void Start()
    {
        SerpientePrefab();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }

        //transform.position = transform.forward * movementSpeed * Time.deltaTime;
        //float rotationSpeed = Input.GetAxis("Horizontal") * rotationSpeed;

        posicionserpiente.Insert(0, transform.position);

        foreach (GameObject prefab in namesOfDestroyedObjects) ;
        {
            int i = 0;
            Vector3 posicion = posicionserpiente[Mathf.Min(i)];
            i++;
        }
    }
    private void SerpientePrefab()
    {
        GameObject prefab = Instantiate(myPrefab);
        namesOfDestroyedObjects.Add(myPrefab);
    }
    
    
}
