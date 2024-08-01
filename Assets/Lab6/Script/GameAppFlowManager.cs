using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Euaungkul.GameDev3.Chapter1
{

    public class GameAppFlowManager : MonoBehaviour
    {
        // Start is called before the first frame update
        protected static bool IsSceneOptionsLoaded;

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }

        public void UnloadScene(string sceneName)
        {
            SceneManager.UnloadSceneAsync(sceneName);
        }

        public void LoadSceneAdditive(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }

        public void LoadOptionsScene(string optionSceneName)
        {
            if (!IsSceneOptionsLoaded)
            {
                SceneManager.LoadScene(optionSceneName, LoadSceneMode.Additive);
                IsSceneOptionsLoaded = true;
            }
        }

        public void UnloadOptionsScene(string optionSceneName)
        {
            if (IsSceneOptionsLoaded)
            {
                SceneManager.UnloadSceneAsync(optionSceneName);
                IsSceneOptionsLoaded = false;
            }
        }

        public void ExitGame()
        {
            Application.Quit();
        }


        #region Scene Load and Unload Events Handler

        private void OnEnable()
        {
            SceneManager.sceneUnloaded += SceneUnloadEventHandler;
            SceneManager.sceneLoaded += SceneLoadedEventHandler;
        }

        private void OnDisable()
        {
            SceneManager.sceneUnloaded -= SceneUnloadEventHandler;
        }

        private void SceneUnloadEventHandler(Scene scene)
        {

        }

        private void SceneLoadedEventHandler(Scene scene, LoadSceneMode mode)
        {
            //If the loaded scene is not the SceneOptions, set flag IsOptionsLoaded to false//
            if (scene.name.CompareTo("SceneOptions") != 0)
            {
                IsSceneOptionsLoaded = false;
            }
        }

        #endregion
    }
}
