using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MyRenderPipeline : RenderPipeline
{
    private MyRenderPipelineAsset renderPipelineAsset;
    public MyRenderPipeline(MyRenderPipelineAsset asset)
    {
        renderPipelineAsset = asset;
    }

    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        var cmd = new CommandBuffer();
        cmd.ClearRenderTarget(true,true,Color.white);
        context.ExecuteCommandBuffer(cmd);
        cmd.Release();

        context.Submit();
    }
}
