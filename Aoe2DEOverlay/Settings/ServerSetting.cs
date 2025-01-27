﻿using System.Windows;
using Newtonsoft.Json.Linq;

namespace Aoe2DEOverlay
{
    public class ServerSetting
    {
        private JObject json;
        
        private static string formatKey = "format";
        private static string marginTopKey = "bottom";
        private static string marginLeftKey = "right";
        private static string marginRightKey = "left";
        private static string marginBottomKey = "top";
        private static string verticalKey = "vertical";
        private static string horizontalKey = "horizontal";
        private static string fontSizeKey = "fontSize";
        
        private static string formatDefault = "server: {server.name}";
        private static double fontSizeDefault = 12.0;

        public ServerSetting(JObject json)
        {
            json[marginTopKey] = 0;
            json[marginLeftKey] = 0;
            json[marginRightKey] = 0;
            json[marginBottomKey] = 0;
            json[fontSizeKey] = fontSizeDefault;
            json[formatKey] = formatDefault;
            json[horizontalKey] = "right";
            json[verticalKey] = "top";
            
            this.json = json;
        }

        public void Load(JObject json)
        {
            this.json = json;
        }
        
        public double MarginTop { get {
            var token = json[marginTopKey];
            if (token?.Value<string>() == null) return 0;
            var top = token.Value<double>();
            return top;
        } }
        
        public double MarginLeft { get {
            var token = json[marginLeftKey];
            if (token?.Value<string>() == null) return 0;
            return token.Value<double>();
        } }
        
        public double MarginRight { get {
            var token = json[marginRightKey];
            if (token?.Value<string>() == null) return 0;
            return token.Value<double>();
        } }
        
        public double MarginBottom { get {
            var token = json[marginBottomKey];
            if (token?.Value<string>() == null) return 0;
            return token.Value<double>();
        } }
        
        public double FontSize { get {
            var token = json[fontSizeKey];
            if (token?.Value<string>() == null) return fontSizeDefault;
            return token.Value<double>();
        } }
        
        public string Format { get {
            var token = json[formatKey];
            if (token?.Value<string>() == null) return "";
            return token.Value<string>();
        } }

        public HorizontalAlignment Horizontal { get {
            var token = json[horizontalKey];
            if (token?.Value<string>() == null) return HorizontalAlignment.Center;
            var horizontal = token.Value<string>();
            if (horizontal?.ToLower() == "left") return HorizontalAlignment.Left;
            if (horizontal?.ToLower() == "right") return HorizontalAlignment.Right;
            return HorizontalAlignment.Center;
        } }
        
        public VerticalAlignment Vertical { get {
            var token = json[verticalKey];
            if (token?.Value<string>() == null) return VerticalAlignment.Center;
            var vertical = token.Value<string>();
            if (vertical?.ToLower() == "top") return VerticalAlignment.Top;
            if (vertical?.ToLower() == "bottom") return VerticalAlignment.Bottom;
            return VerticalAlignment.Center;
        } }
    }
}