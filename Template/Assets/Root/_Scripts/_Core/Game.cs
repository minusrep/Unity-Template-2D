﻿using Root._Core._Locator;
using Root._Services._Core;
using Root._Services._SceneLoader;
using System.Collections;

namespace Root._Core
{
    public class Game : IGame
    {
        public static IGame Instance => _instance;
        
        private static Game _instance { get; set; }

        public ILocator<IService> ServiceLocator { get; private set; }

        public void Init(ILocator<IService> serviceLocator)
        {
            _instance = this;

            ServiceLocator = serviceLocator;
        }

        public IEnumerator Run()
        {
            var sceneLoader = ServiceLocator.Get<ISceneLoader>();

            yield return sceneLoader.LoadSceneAsync(SceneType.Game);
        }
    }
}
