﻿using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XChrome.cs.xchrome
{
    public class XChromeClient
    {

        public long Hwnd { get; set; } = 0;
        public uint ProcessId { get; set; } = 0;

        /// <summary>
        /// 弹出插件小窗口绑定
        /// </summary>
        public uint ExtensionsHwnd { get; set; } = 0;

        public IBrowserContext? BrowserContext { get; set; } = null;

        public long Id { get; set; } = 0;

        public string Name { get; set; } = "";
        public string DataPath { get; set; } = "";
        public string Proxy { get; set; } = "";
        public string UserAgent { get; set; } = "";

        public string Evns { get; set; } = "";

        public string Extensions { get; set; } = "";

        public ViewportSize? ViewportSize { get; set; } = null;

        //内部页面大小
        public int LegacyWindowWidth = 0;
        public int LegacyWindowHeight = 0;
    }

    public struct XWindowRect
    {
        public int Left;   // 窗口左上角的 X 坐标
        public int Top;    // 窗口左上角的 Y 坐标
        public int Width;  // 窗口宽度
        public int Height; // 窗口高度

        public XWindowRect(int left, int top, int width, int height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"Left: {Left}, Top: {Top}, Width: {Width}, Height: {Height}";
        }
    }
}
