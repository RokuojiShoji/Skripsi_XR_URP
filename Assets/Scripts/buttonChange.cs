using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class buttonChange : MonoBehaviour
{
    public Material selectMaterial = null;
    
    private MeshRenderer meshRenderer = null;
    private Material originalMaterial = null;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;
    }

    public void ChangeColor()
    {
        meshRenderer.material = selectMaterial;
    }

    public void TurnBackColor()
    {
        meshRenderer.material = originalMaterial;
    }
    
}
