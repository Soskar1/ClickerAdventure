using System.Collections.Generic;
using UnityEngine;

public class ArtefactImplemetation : MonoBehaviour
{
    public List<Artefact> artefacts;

    private void Awake()
    {
        foreach (Artefact artefact in artefacts)
            Debug.Log(artefact);
    }
}
