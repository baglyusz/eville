using LLMUnity;
using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class SimpleInteraction : MonoBehaviour
    {
        public LLM llm;
        public TMP_InputField playerText;
        public TMP_Text AIText;

        void Start()
        { 
            //playerText.Select();
        }

        public void OnInputFieldSubmit()
        {
            Debug.Log("anyád");
            //playerText.interactable = false;
            string message = playerText.text;
            AIText.SetText("i have been trying to reach you about your car's extended warranty");
            _ = llm.Chat(message, SetAIText, AIReplyComplete);
        }

        public void SetAIText(string text)
        {
            AIText.SetText(text);
        }

        public void AIReplyComplete()
        {
            playerText.interactable = true;
            playerText.Select();
           // playerText.text = "";
        }
        
        /*
        public void CancelRequests()
        {
            llm.CancelRequests();
            AIReplyComplete();
        } */
    }
}