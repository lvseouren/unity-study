using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SwitchRenderPipelineAsset : MonoBehaviour
{
    public RenderPipelineAsset assetA;
    public RenderPipelineAsset assetB;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GraphicsSettings.renderPipelineAsset = assetA;
            Debug.Log("Active render pipeline asset is: " + GraphicsSettings.renderPipelineAsset.name);
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            GraphicsSettings.renderPipelineAsset = assetB;
            Debug.Log("Active render pipeline asset is: " + (GraphicsSettings.renderPipelineAsset?GraphicsSettings.renderPipelineAsset.name:"null"));
        }
    }
}
