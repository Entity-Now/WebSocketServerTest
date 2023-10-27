using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Security.Cryptography.X509Certificates;

namespace WebSocketServerTest.Core
{
    public class Ws
    {
        public static WebSocketServer wss { get; set; }
        static public void WssStart(string url)
        {
            wss = new WebSocketServer(url);
            // 为websocket-sharp客户端和服务器配置SSL证书。
            wss.SslConfiguration.ServerCertificate = new X509Certificate2("myCert.pfx", "123456");
            wss.AddWebSocketService<Repeater>("/repeater");
            wss.Start();
            if(wss.IsListening)
                PrintMsg.SendMsg($"WebSocket address is:{url} 已启动");
            else
                PrintMsg.SendMsg("启动失败");
        }
        static public void Stop()
        {
            wss.Stop();
            PrintMsg.SendMsg("WebSocket 已关闭");
        }
    }
}
