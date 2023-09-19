using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    List<Message> messageList = new List<Message>();
    public int maxMessages;

    public GameObject chatPanel, textObject;
    public TMP_InputField chatBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(chatBox.text != "")
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                SendMessageToChat(chatBox.text);
                chatBox.text = "";
            }
        }
        else
        {
            if(!chatBox.isFocused && Input.GetKeyDown(KeyCode.Return))
            {
                chatBox.ActivateInputField();
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            SendMessageToChat("Nhu Lon");
        }       
    }

    public void SendMessageToChat(string text)
    {
        if(messageList.Count >= maxMessages)
        {
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }

        Message message = new Message();
        message.text = text;

        GameObject newText = Instantiate(textObject, chatPanel.transform);

        message.textObject = newText.GetComponent<TextMeshProUGUI>();

        message.textObject.text = message.text;

        messageList.Add(message);
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public TextMeshProUGUI textObject;
}

