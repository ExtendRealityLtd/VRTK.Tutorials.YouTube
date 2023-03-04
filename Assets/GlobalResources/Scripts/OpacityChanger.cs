using UnityEngine;

public class OpacityChanger : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    public void ChangeOpacity(float value)
    {
        Color currentColor = meshRenderer.material.color;
        currentColor.a = value;
        meshRenderer.material.color = currentColor;
    }
}
