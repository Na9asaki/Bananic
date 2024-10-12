using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Assets.Renderers
{
    [Serializable]
    internal class OutlineFeature : ScriptableRendererFeature
    {
        [SerializeField] private RTHandle _handle;
        [SerializeField] private RenderTexture _text;
        [SerializeField] private LayerMask _mask;
        [SerializeField] private Settings _settings = new Settings();
        [SerializeField] private Material _material;

        [Serializable] 
        public class Settings
        {
            public Material material;
        }

        private OutlinePass pass;
        private RTHandle _rtHandle;
        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (_text != null)
            {
                renderer.EnqueuePass(pass);
            }
        }

        public override void Create()
        {
            if (_text != null)
            {
                _rtHandle = RTHandles.Alloc(_text);
                pass = new OutlinePass(_rtHandle, _mask, _settings.material);
            }
        }
    }
}
