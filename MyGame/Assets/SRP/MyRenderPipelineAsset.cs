using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Rendering/MyRenderPipelineAsset")]
public class MyRenderPipelineAsset : RenderPipelineAsset
{
    public Color exampleColor;
    public string exampleString;
    protected override RenderPipeline CreatePipeline()
    {
        return new MyRenderPipeline(this);
        throw new System.NotImplementedException();
    }
}
