using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Bot_Application2.Model;
using Bot_Application2.Answer_Message;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections.Generic;
using LineMessagingAPISDK;
using LineMessagingAPISDK.Models;

namespace Bot_Application2.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {

        public static int Image_Use = 0;
        private string[] fb_user_name;
        private string user_name;
        private string br;
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Microsoft.Bot.Connector.Activity;
            
            var reply = context.MakeMessage();
            
            if (activity.Attachments.Count > 0)
            {
                if (activity.ChannelId.Contains("direct"))
                {
                    br = "\n";
                    var message_type = activity.Attachments[0];
                    if (message_type.ContentType.Contains("image"))
                        reply.Text = "請不要傳圖片哦" + br + "機器人無法解析圖片" + br + "請使用文字跟機器人對話" + br + "(ㆆᴗㆆ)";
                }
                else
                {
                    br = "<br/>";
                    var message_type = activity.Attachments[0];
                    if (message_type.ContentType.Contains("image"))
                        reply.Text = "請不要傳圖片哦" + br + "機器人無法解析圖片" + br + "請使用文字跟機器人對話" + br + "(ㆆᴗㆆ)";
                }
            }   
            else
            {
                if (activity.ChannelId.Contains("facebook"))
                {
                    br = "<br/>";
                    fb_user_name = activity.From.Name.Split(' ');
                    reply.Text = LUIS_Predict(activity.Text, fb_user_name[0], br);
                    
                }
                else if (activity.ChannelId.Contains("direct"))
                {
                    br = "\n";
                    reply.Text = LUIS_Predict(activity.Text, user_name, br);
                }
                else
                {
                    br = "<br/>";
                    user_name = activity.From.Name;
                    reply.Text = LUIS_Predict(activity.Text, user_name, br);
                }
            }
            if (Image_Use > 0)
            {
                if (!activity.ChannelId.Contains("direct"))
                {
                    switch (Image_Use)
                    {
                        case 1:
                            reply = Image_Message.ISU_Map(reply);
                            Image_Use = 0;
                            break;
                        case 2:
                            reply = Image_Message.ISU_Coffee_Map(reply);
                            Image_Use = 0;
                            break;
                        case 3:
                            reply = Image_Message.ISU_Dog(reply);
                            Image_Use = 0;
                            break;
                    }
                }
                else
                {
                    switch (Image_Use)
                    {
                        case 1:
                            reply.Text += br + "http://i.imgur.com/KPAwGRB.jpg";
                            Image_Use = 0;
                            break;
                        case 2:
                            reply.Text += br + "http://i.imgur.com/Aq3wFIq.jpg" + br +
                                "http://i.imgur.com/Zmy1Tfl.jpg" + br +
                                "http://i.imgur.com/6rVybfb.jpg" + br +
                                "http://i.imgur.com/eJeFkB7.jpg";
                            Image_Use = 0;
                            break;
                        case 3:
                            reply.Text += br + "狗狗們的照片：https://goo.gl/qb5cTe";
                            Image_Use = 0;
                            break;
                    }
                }
            }


                //-----------------FB Button Message---------------------------------------------
                /*if (activity.ChannelId == "facebook")
                {
                    reply.Text = LUIS_Predict(activity.Text, user_name);
                }
                else
                {
                    reply.ChannelData = new FacebookChannelData()
                    {
                        Attachment = new FacebookAttachment()
                        {
                            Payload = new FacebookGenericTemplate()
                            {
                                Elements = new object[]
                            {
                                new FacebookGenericTemplateContent()
                                {
                                    Buttons = new[]
                                    {
                                        new FacebookShareButton()
                                    }
                                }
                            }
                            }
                        }
                    };
                }*/
            
            await context.PostAsync(reply);

            context.Wait(MessageReceivedAsync);
        }

        private string LUIS_Predict(string message, string user_name, string br)
        {
            string result_message = "";
            string id = "cb0851d7-5db2-4b75-a103-1d416de35c5a";
            string key = "0f3c22b7e50f4328abff4895938832f6";
            string LUISUri = "";
            
            LUISUri = "https://westus.api.cognitive.microsoft.com/luis/v2.0/apps/" + id + "?subscription-key=" + key + "&timezoneOffset=480&verbose=true&q=" + message ;

            LUISResponse objLUISRes = JsonConvert.DeserializeObject<LUISResponse>(JsonParsing(LUISUri));

            if (objLUISRes.topScoringIntent.intent.Count() > 0)
            {
                if (objLUISRes.topScoringIntent.score > 0.5 && objLUISRes.entities.Count() > 0)
                {
                    result_message = Result_Message_Selection.Message_Selection(objLUISRes, user_name, br);
                }
                else
                    result_message = "機器人看不懂你在說什麼" + br +
                        "感謝你問的問題 此問題將會加入資料庫" + br +
                        "對於沒辦法回答你的問題 真的很抱歉(´･ω･`)" + br +
                        "作者會盡快更新";
            }
            return result_message;
        }

        private string JsonParsing(string xUrl)
        {
            string _JsonResult = "";
            try
            {
                WebRequest request = WebRequest.Create(xUrl);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                _JsonResult = reader.ReadToEnd();
                reader.Dispose();
                dataStream.Dispose();
                response.Close();
            }
            catch (Exception e)
            {
                _JsonResult = e.ToString();
            }
            return _JsonResult;
        }



    }
}