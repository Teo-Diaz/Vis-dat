using UnityEngine;

public class DesactivarObjeto : MonoBehaviour
{
    public GameObject objetoADesactivar;

    public void Desactivar()
    {
        objetoADesactivar.SetActive(false);
    }
}