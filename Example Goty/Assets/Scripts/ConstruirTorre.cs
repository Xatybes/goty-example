using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConstruirTorre : MonoBehaviour
{
    public GameObject panel;
    public GameObject opcionDelPanel;
    public Transform posicion;
    
   

    void OnMouseDown()
    {
        GameObject nuevaTorre;
        nuevaTorre = Instantiate(opcionDelPanel, new Vector3(posicion.position.x, posicion.position.y, posicion.position.z), Quaternion.identity);
        Destroy(posicion.gameObject);
        nuevaTorre.SetActive(true);
        panel.SetActive(false);
    }


}
