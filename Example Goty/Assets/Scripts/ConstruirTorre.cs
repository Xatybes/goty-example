using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConstruirTorre : MonoBehaviour
{
    public GameObject panel;
    public GameObject torreArquera;
    public Transform posicionDeTorre;
    
   

    void OnMouseDown()
    {
        GameObject nuevaTorre;
        nuevaTorre = Instantiate(torreArquera, new Vector3(posicionDeTorre.position.x, posicionDeTorre.position.y, posicionDeTorre.position.z), Quaternion.identity);
        Destroy(posicionDeTorre.gameObject);
        nuevaTorre.SetActive(true);
        panel.SetActive(false);
    }


}
