﻿using BeardedPlatypus.Camera.Core.Behaviours;
using BeardedPlatypus.Camera.Presets.SetPosition;
using UnityEngine;
using Zenject;

namespace BeardedPlatypus.Camera.Zenject.Presets
{
    /// <summary>
    /// <see cref="SmoothSetPositionBehaviourInstaller"/> provides the
    /// <see cref="ISetPositionBehaviour"/> dependency as a
    /// <see cref="SmoothSetPositionBehaviour"/>.
    /// </summary>
    public sealed class SmoothSetPositionBehaviourInstaller : MonoInstaller
    {
        [SerializeField] private float maxTransitionTime = 0.5F;

        public override void InstallBindings()
        {
            Container.Bind<float>()
                     .FromInstance(maxTransitionTime)
                     .WhenInjectedInto<SmoothSetPositionBehaviour>();
            Container.Bind<ISetPositionBehaviour>()
                     .To<SmoothSetPositionBehaviour>()
                     .AsSingle();
        }
    }
}