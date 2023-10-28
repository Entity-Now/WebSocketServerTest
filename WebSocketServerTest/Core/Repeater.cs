using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSocketServerTest.Core
{
    public class Repeater : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            string msg = "";
            if (e.IsText)
            {
                msg = e.Data;
            }
            else
            {
                msg = "binary";
            }
            this.Send(msg);
            PrintMsg.SendMsg($"[{this.StartTime}] 收到{this.ID}客户的信息：{msg}.");
        }
        protected override void OnOpen()
        {
            PrintMsg.SendMsg($"[{this.StartTime}] 与客户{this.ID}连接成功.");
        }
        protected override void OnClose(CloseEventArgs e)
        {
            PrintMsg.SendMsg($"[{this.StartTime}] 与客户{this.ID}连接断开连接.");
        }
        protected override void OnError(ErrorEventArgs e)
        {
            PrintMsg.SendMsg($"[{this.StartTime}] 与客户{this.ID}连接时出错了：{e.Message}.");
        }
    }
}
