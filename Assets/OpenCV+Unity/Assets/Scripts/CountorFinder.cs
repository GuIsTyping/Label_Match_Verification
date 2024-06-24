using System.Collections;
using System.Collections.Generic;
using OpenCvSharp;
using OpenCvSharp.Demo;
using UnityEngine;

public class CountorFinder : WebCamera
{
    private Mat image;

    protected override bool ProcessTexture(WebCamTexture input, ref Texture2D output)
    {
        image = OpenCvSharp.Unity.TextureToMat(input);

        //Do cool processing stuff


        if(output == null)
            output = OpenCvSharp.Unity.MatToTexture(image);
        else
            OpenCvSharp.Unity.MatToTexture(image,output);

        return true;
    }


}
