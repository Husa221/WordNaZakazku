using UnityEngine;
using UnityEngine.Rendering.Universal;

public class DisableMsaaOnMac : MonoBehaviour
{
    [SerializeField] UniversalRenderPipelineAsset pipelineAsset;

    void Start()
    {
        if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer)
        {
            Debug.Log("Disabled MSAA");
            pipelineAsset.msaaSampleCount = 0;
        }
        else
        {
            Debug.Log("Not running on Mac");
        }
    }
}