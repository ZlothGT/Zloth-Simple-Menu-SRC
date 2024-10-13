using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

namespace Zloths_Simple_Menu
{
    public class SimpleUI
    {
        private static GameObject canvasObject;
        private static Text roomText;
        private static Text playerNameText;
        private static Text modsEnabledText;
        private static Text menuNameText;
        private static Text versionText;
        private static Image iconImage;

        private const string menuName = "Zloth's Simple Menu";
        private const string menuVersion = "1.0.1";
        private static Sprite menuIcon; // You'll need to assign this sprite manually for your image

        public static void CreateUI()
        {
            if (canvasObject == null) // Prevent creating multiple UIs
            {
                // Create Canvas
                canvasObject = new GameObject("SimpleUICanvas");
                Canvas canvas = canvasObject.AddComponent<Canvas>();
                canvas.renderMode = RenderMode.ScreenSpaceOverlay;
                CanvasScaler scaler = canvasObject.AddComponent<CanvasScaler>();
                scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

                // Create a panel to hold the UI elements
                GameObject panelObject = new GameObject("Panel");
                panelObject.transform.SetParent(canvasObject.transform);
                RectTransform panelRect = panelObject.AddComponent<RectTransform>();
                panelRect.sizeDelta = new Vector2(300, 200); // Panel size
                panelRect.anchoredPosition = new Vector2(50, -50); // Panel position on the screen
                Image panelImage = panelObject.AddComponent<Image>();
                panelImage.color = new Color(0, 0, 0, 0.5f); // Semi-transparent background

                // Add UI elements (Texts and Image)
                roomText = CreateText(panelObject, "RoomText", "Room: Unknown", new Vector2(0, -20));
                playerNameText = CreateText(panelObject, "PlayerNameText", "Player: Unknown", new Vector2(0, -50));
                modsEnabledText = CreateText(panelObject, "ModsEnabledText", "Mods: None", new Vector2(0, -80));
                menuNameText = CreateText(panelObject, "MenuNameText", "Menu: " + menuName, new Vector2(0, -110));
                versionText = CreateText(panelObject, "VersionText", "Version: " + menuVersion, new Vector2(0, -140));
                iconImage = CreateIcon(panelObject, "IconImage", menuIcon, new Vector2(0, -180), new Vector2(50, 50));

                UpdateUI(); // Update immediately after creation
            }
        }

        public static void UpdateUI()
        {
            if (canvasObject != null)
            {
                // Update room name
                if (PhotonNetwork.InRoom)
                {
                    roomText.text = "Room: " + PhotonNetwork.CurrentRoom.Name;
                }
                else
                {
                    roomText.text = "Room: Not in room";
                }

                // Update player name
                playerNameText.text = "Player: " + PhotonNetwork.LocalPlayer.NickName;

                // Update mods enabled (example)
                modsEnabledText.text = "Mods: Fly, Speed Boost"; // Add real mod checking here

                // Update icon (you need to assign the menuIcon sprite before)
                // iconImage.sprite = menuIcon;
            }
        }

        private static Text CreateText(GameObject parent, string name, string content, Vector2 position)
        {
            GameObject textObject = new GameObject(name);
            textObject.transform.SetParent(parent.transform);

            Text text = textObject.AddComponent<Text>();
            text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            text.text = content;
            text.fontSize = 14;
            text.alignment = TextAnchor.MiddleLeft;

            RectTransform rect = text.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(280, 30);
            rect.anchoredPosition = position;

            return text;
        }

        private static Image CreateIcon(GameObject parent, string name, Sprite icon, Vector2 position, Vector2 size)
        {
            GameObject iconObject = new GameObject(name);
            iconObject.transform.SetParent(parent.transform);

            Image image = iconObject.AddComponent<Image>();
            image.sprite = icon;

            RectTransform rect = image.GetComponent<RectTransform>();
            rect.sizeDelta = size;
            rect.anchoredPosition = position;

            return image;
        }

        public static void DestroyUI()
        {
            if (canvasObject != null)
            {
                GameObject.Destroy(canvasObject);
                canvasObject = null;
            }
        }
    }
}
