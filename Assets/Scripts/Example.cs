using LLMUnity;
using UnityEngine;

namespace Assets.Scripts
{
    public class Example: MonoBehaviour
    {
        public LLM llm;

        void HandleReply(string reply)
        {
            // do something with the reply from the model
            Debug.Log(reply);
        }

        void ReplyCompleted()
        {
            // do something when the reply from the model is complete
            Debug.Log("The AI replied");
        }

        void Game()
        {
            //game function
            string message = "Henlo fren!";
            _ = llm.Chat(message, HandleReply, ReplyCompleted);
        }
    }
}