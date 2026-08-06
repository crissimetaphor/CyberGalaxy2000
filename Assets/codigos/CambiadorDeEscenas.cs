using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorDeEscenas : MonoBehaviour
{
    public void CambiarAEscenaSeleccion()
    {
        SceneManager.LoadScene("SeleccionPlaneta");
    }
}