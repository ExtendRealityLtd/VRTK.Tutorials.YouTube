using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem particles;

    public void SetEmissionRate(float value)
    {
        ParticleSystem.EmissionModule emissions = particles.emission;
        emissions.rateOverTime = value;
    }
}